using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TutorialMgr
{
    public partial class TutorialMain : Form
    {
        private FlowLayoutPanel pan;

        public TutorialMain()
        {
            InitializeComponent();
        }

        private List<TopicData> topicDataList = new List<TopicData>(); 

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowser.SelectedPath = txtFilePath.Text;
            DialogResult result = folderBrowser.ShowDialog();
            txtFilePath.Text = folderBrowser.SelectedPath;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
           pan = new FlowLayoutPanel();
            
           pan.Width = this.panTopicsData.Width;
           pan.Height = this.panTopicsData.Height;
           pan.AutoScroll = true;

           DirectoryInfo dir = new DirectoryInfo(txtFilePath.Text);

            var topicDirectories = dir.GetDirectories();
            foreach (DirectoryInfo topicDirectory in topicDirectories)
            {
                TopicData topicData = this.GetTopicData(topicDirectory);
                topicDataList.Add(topicData);
                pan.Controls.Add(topicData);
            }

            this.panTopicsData.Controls.Add(pan);
            this.panTopicsData.Update();
            this.panTopicsData.Refresh();
            this.Refresh();
            
        }
        
        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(txtFilePath.Text);
            lblCurrentCourseFld.Text = directory.Name;
        }

        private TopicData GetTopicData(DirectoryInfo dir)
        {
           TopicData t = new TopicData(dir);
           return t;
        }

        private void TutorialMain_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilePath.Text))
            {
                folderBrowser.SelectedPath = txtFilePath.Text;
            }
        }

        private void PrintData()
        {
            foreach (TopicData data in topicDataList)
            {
                foreach (Topic topic in data.topics)
                {
                    Console.WriteLine("File {0} Renamed with {1}",topic.CurrentPath,topic.Rename);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessRenaming();
            lblErrorMessage.Text = "Done!";
        }

        private void ProcessRenaming()
        {
            foreach (TopicData data in topicDataList)
            {
                
                foreach (Topic topic in data.topics)
                {
                    if (!string.IsNullOrEmpty(topic.Rename))
                    {
                        RenameFile(topic);
                    }
                }
            }
        }

        private void RenameFile(Topic topicFile)
        {
            try
            {
                string newName = topicFile.Rename.Replace(":","-").Replace("/"," AND ");
                string extension = topicFile.FilePath.Extension;
                string fileNumberText = (topicFile.FileNumber < 10) ? "0" + topicFile.FileNumber.ToString() : topicFile.FileNumber.ToString();

                if (chkExtension.Checked)
                {
                    extension = (string.IsNullOrEmpty(extension)) ? ".mov" : extension;
                }

                if (chkCourse.Checked)
                {
                    newName = string.Format("{0}-{1}", topicFile.FilePath.Directory.Name, newName);
                }
                newName = string.Format("{0}_{1}{2}", fileNumberText, newName, extension);
                newName = string.Format(@"{0}\{1}", topicFile.FilePath.DirectoryName, newName);
                topicFile.FilePath.MoveTo(newName);

            }
            catch (Exception)
            {

                this.lblErrorMessage.Text += topicFile.FilePath.FullName + "\n";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            this.pan.Controls.Clear();
        }
    }
}
