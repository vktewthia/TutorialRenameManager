using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TutorialMgr
{
    public partial class TopicData : UserControl
    {
        public List<Topic> topics = new List<Topic>();
        public DirectoryInfo TopicDirectory { get; set; }

        public TopicData(DirectoryInfo topicDirectory)
        {
            InitializeComponent();
            this.TopicDirectory = topicDirectory;
        }

        public void RefreshTopics()
        {
            topics = new List<Topic>();
            this.Controls.Clear();
            txtTopicCaption.Text = string.Empty;
            this.tblLayout.RowCount = 0;
        }

        private void TopicData_Load(object sender, EventArgs e)
        {

            this.txtTopicCaption.Text = this.TopicDirectory.Name;
            var fileList = this.TopicDirectory.GetFiles().ToList();
            this.tblLayout.RowCount = fileList.Count;
            int row = 0;
            SortFiles(fileList);
            foreach (FileInfo fileInfo in fileList)
            {
                Topic t = this.getTopic(fileInfo,++row);
                topics.Add(t);
                this.tblLayout.Controls.Add(t);
            }

            this.tblLayout.Refresh();
        }

        private Topic getTopic(FileInfo file,int rowNumber)
        {
            Topic topic = new Topic();
            topic.FilePath = file;
            topic.CurrentPath = string.Format("{0}",file.Name);
            topic.FileNumber = rowNumber;
            return topic;
        }

        private void SortFiles(List<FileInfo> files)
        {
            files.Sort(new FileComparer());
        }
    }

    class FileComparer : IComparer<FileInfo>
    {

        public int Compare(FileInfo x, FileInfo y)
        {
            if (GetFileNumber(x) > GetFileNumber(y))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }


        private int GetFileNumber(FileInfo file)
        {
            string fileName = (string.IsNullOrEmpty(file.Extension))?file.Name:file.Name.Replace(file.Extension, "");
            fileName = fileName.Replace("(", "").Replace(")", "").Replace("_", "").Replace(" ","");
            fileName = fileName.Substring(1, fileName.Length-1);
            int fileNumber = 0;
            return int.TryParse(fileName, out fileNumber) ? fileNumber : fileNumber;
        }
    }
}
