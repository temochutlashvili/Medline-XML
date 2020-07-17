using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLEditor
{
    public partial class MainForm : Form
    {
        string currentFile;
        Boolean dirty = true;

        string clipboardText;
        ArticleSet articleSet;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //for(int i = 0; i < 10; i++) {
            //    accordion1.Add(new AccordionItem().getControl(), "1", "1", 0, false);
            //}

            articleSet = new ArticleSet(accordion1);
            rawXML.Text = articleSet.toString();
        }

        private void FocusEnter(object sender, EventArgs e)
        {

        }

        private void AddArticle_ButtonClick(object sender, EventArgs e)
        {
            accordion1.Add(new AccordionItem().getControl(), "1", "1", 0, false);
        }

        private void Expand_ButtonClick(object sender, EventArgs e)
        {
            accordion1.Open();
        }

        private void ImportClipboard_ButtonClick(object sender, EventArgs e)
        {
            toolStripProgressBar_importClipboard.Visible = true;
            toolStripProgressBar_importClipboard.Minimum = 0;
            toolStripProgressBar_importClipboard.Value = 0;

            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                clipboardText = Clipboard.GetText(TextDataFormat.Text);
                toolStripProgressBar_importClipboard.Maximum = clipboardText.Length;
                backgroundWorker.RunWorkerAsync(argument: clipboardText);
            }
        }

        public static void RemoveAt<T>(ref T[] arr, int index)
        {
            for (int a = index; a < arr.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                arr[a] = arr[a + 1];
            }
            // finally, let's decrement Array's size by one
            Array.Resize(ref arr, arr.Length - 1);
        }


        public void importFromClipboard(string clipText)
        {
            var r = new Regex(@"\s*SUMMARY\s*(.*?)\s*Key words:\s*(.*?)\s*\.", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var matchCollection = r.Matches(clipText);

            foreach (Match match in matchCollection)
            {
                var article = new Article(accordion1);

                var result = Regex.Split(match.Groups[1].Value, "\r\n|\r|\n");

                // Getting title
                while (result.Length > 0 && result[0] != "")
                {
                    article.ArticleTitle = article.ArticleTitle + ' ' + result[0];
                    RemoveAt(ref result, 0);
                }

                // Remove space
                while (result.Length > 0 && result[0] == "") RemoveAt(ref result, 0);

                // Authors
                var authorsString = "";
                while (result.Length > 0 && result[0] != "")
                {
                    authorsString = authorsString + result[0];
                    RemoveAt(ref result, 0);
                }

                // Remove space
                while (result.Length > 0 && result[0] == "") RemoveAt(ref result, 0);

                // Affiliation
                var affiliationString = "";
                while (result.Length > 0 && result[0] != "")
                {
                    affiliationString = affiliationString + result[0];
                    RemoveAt(ref result, 0);
                }

                article.parseAuthors(authorsString, affiliationString.Trim());

                // Remove space
                while (result.Length > 0 && result[0] == "") RemoveAt(ref result, 0);

                // abstract
                var abstractText = "";
                while (result.Length > 0)
                {
                    abstractText = abstractText + result[0];
                    RemoveAt(ref result, 0);
                }

                var keyWords = match.Groups[2].Value;

                backgroundWorker.ReportProgress(match.Index, article);
            }
        }

        private void backgroundWork(object sender, DoWorkEventArgs e)
        {
            string text = (string) e.Argument;
            importFromClipboard(text);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar_importClipboard.Value = e.ProgressPercentage;
            Article article = (Article)e.UserState;
            articleSet.addAricle(article);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            rawXML.Lines = articleSet.toString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            toolStripProgressBar_importClipboard.Visible = false;
        }

        private void saveButtonClick(object sender, EventArgs e)
        {
            saveToFile();
        }

        private void openFileClick(object sender, EventArgs e)
        {
            if (dirty)
            {
                DialogResult dr = MessageBox.Show("В файл вносились изменения, сохранить?", "Внимание", MessageBoxButtons.YesNoCancel);
                switch (dr)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        saveToFile();
                        break;
                }
            }

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var str = System.IO.File.ReadAllText(openFileDialog.FileName);
                var serializer = new XmlSerializer(typeof(ArticleSet));
                using (TextReader reader = new StringReader(str))
                {
                    try {
                        articleSet = (ArticleSet)serializer.Deserialize(reader);
                        articleSet.setAccordion(accordion1);
                        articleSet.rebuildAccordion();
                    } catch(Exception ex) {
                        MessageBox.Show("Пиздец с XML");
                    }
                    
                }
                
            }
        }

        private void saveToFile()
        {
            if (currentFile == null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                currentFile = saveFileDialog.FileName;
            }

            System.IO.File.WriteAllText(currentFile, articleSet.toString());
        }
    }
}
