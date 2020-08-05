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
        const int RawTabPage = 2;
        int previousPage;
        string currentFile;
        Boolean dirty = true;

        string clipboardText;
        ArticleSet articleSet;
        String rawText = "";

        CharacterMap charMap = new CharacterMap();

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Journal.Instance.PublisherName = publisherTextBox.Text;
            Journal.Instance.JournalTitle = nameTextBox.Text;
            Journal.Instance.ISSN = issnTextBox.Text;
            Journal.Instance.Issue = issueTextBox.Text;
            Journal.Instance.Volume = volumeTextBox.Text;

            PubDate.Instance.Month = monthTextBox.Text = DateTime.Now.ToString("MM");
            PubDate.Instance.Year = yearTextBox.Text = DateTime.Now.ToString("yyyy");

            charMap.charMapPressedEvent += charMapPressed;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            articleSet = new ArticleSet(accordion1);
            rawXML.Text = articleSet.toString();
        }

        private void FocusEnter(object sender, EventArgs e)
        {
            
        }

        private void AddArticle_ButtonClick(object sender, EventArgs e)
        {
            articleSet.addAricle(new Article(accordion1));
        }

        private void Expand_ButtonClick(object sender, EventArgs e)
        {
            accordion1.Open();
        }

        private void ImportClipboard_ButtonClick(object sender, EventArgs e)
        {
            toolStripButton_Add.Enabled = false;
            toolStripSplitButton_AddClipboard.Enabled = false;
            toolStrip2.Enabled = false;
            stopJobButton.Visible = true;
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

        private void importOverwrite_ButtonClick(object sender, EventArgs e)
        {
            if (!askForSave()) return;
            articleSet.Clear();
            rawText = "";
            accordion1.Clear();

            ImportClipboard_ButtonClick(sender, e);
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
                var titleText = "";
                while (result.Length > 0 && result[0] != "")
                {
                    //article.ArticleTitle = article.ArticleTitle + ' ' + result[0];
                    titleText = titleText + result[0];
                    RemoveAt(ref result, 0);
                }

                RawText titleInstance = new RawText();
                titleInstance.text = titleText;
                article.titleInstance = titleInstance;

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

                //article.Abstract = abstractText;
                RawText abstractInstance = new RawText();
                abstractInstance.text = abstractText;
                article.abstractInstance = abstractInstance;

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
            stopJobButton.Visible = false;
            toolStripButton_Add.Enabled = true;
            toolStripSplitButton_AddClipboard.Enabled = true;
            toolStrip2.Enabled = true;
        }

        private void stopButtonClick(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (!askForSave()) return;
            articleSet.Clear();
            rawText = "";
            accordion1.Clear();
        }

        private void saveButtonClick(object sender, EventArgs e)
        {
            saveToFile();
        }

        private void openFileClick(object sender, EventArgs e)
        {
            if (!askForSave()) return;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var str = System.IO.File.ReadAllText(openFileDialog.FileName);
                var serializer = new XmlSerializer(typeof(ArticleSet));
                using (TextReader reader = new StringReader(replace_ampersands(str)))
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
            if (!generateArticleSet()) return;

            if (currentFile == null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                currentFile = saveFileDialog.FileName;
            }

            System.IO.File.WriteAllText(currentFile, articleSet.toString());
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(((TabControl)sender).SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case RawTabPage:
                    generateRaw();
                    rawText = rawXML.Text;
                    break;
            }
        }

        private void generateRaw()
        {
            rawXML.Lines = articleSet.toString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        }

        private Boolean generateArticleSet()
        {
            using (TextReader reader = new StringReader(replace_ampersands(rawXML.Text)))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(ArticleSet));
                    articleSet = (ArticleSet)serializer.Deserialize(reader);
                    articleSet.setAccordion(accordion1);
                    articleSet.rebuildAccordion();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Пиздец с XML");
                    return false;
                }
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (previousPage == RawTabPage)
            {
                e.Cancel = !generateArticleSet();
            };
        }

        private void tabControl1_Deselected(object sender, TabControlEventArgs e)
        {
            previousPage = e.TabPageIndex;
        }

        private void rawXML_TextChanged(object sender, EventArgs e)
        {
            undoButton.Enabled = !rawText.Equals(rawXML.Text);
        }

        private void undoClick(object sender, EventArgs e)
        {
            rawXML.Text = rawText;
        }

        private void characterMapClick(object sender, EventArgs e)
        {
            charMap.Owner = this;
            charMap.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            charMap.Dispose();
            this.Dispose();
        }

        private void charMapPressed(object sender, CharMapEventArgs e)
        {
            var control = FindFocusedControl(this);
            if(control is HighlightedTextBox)
            {
                var h = (HighlightedTextBox)control;
                h.SelectionStart += h.SelectionLength;
                h.SelectionLength = 0;
                h.SelectedText = '&' + ((int)e.pressedChar).ToString() + ';';
            }
        }

        public static Control FindFocusedControl(Control control)
        {
            var container = control as IContainerControl;
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as IContainerControl;
            }
            return control;
        }

        private string replace_ampersands(string xml)
        {
            return xml.Replace("&", "&amp;");
        }

        private void paramsChanged(object sender, EventArgs e)
        {
            Journal journal = Journal.Instance;
            journal.pubDate.Month = monthTextBox.Text;
            journal.pubDate.Year = yearTextBox.Text;
            journal.PublisherName = publisherTextBox.Text;
            journal.JournalTitle = nameTextBox.Text;
            journal.ISSN = issnTextBox.Text;
            journal.Issue = issueTextBox.Text;
            journal.Volume = volumeTextBox.Text;
        }

        private Boolean askForSave()
        {
            if (dirty)
            {
                DialogResult dr = MessageBox.Show("В файл вносились изменения, сохранить?", "Внимание", MessageBoxButtons.YesNoCancel);
                switch (dr)
                {
                    case DialogResult.Cancel:
                        return false;
                    case DialogResult.Yes:
                        saveToFile();
                        return true;
                }
            }

            return true;
        }

    }
}
