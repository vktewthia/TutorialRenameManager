using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialMgr
{
    public partial class Topic : UserControl
    {
        public Topic()
        {
            InitializeComponent();
        }

        public FileInfo FilePath  { get; set; }
        public string CurrentPath
        {
            get { return lblTopic.Text; }
            set { lblTopic.Text = value; }
        }
        public string Rename
        {
            get { return txtTopicRename.Text; }
        }
        public int FileNumber
        {
            get { return Convert.ToInt32(cmbNumber.Text); }
            set { cmbNumber.SelectedText = value.ToString(); }

        }

        public void RefreshTopics()
        {
            FilePath = null;
            lblTopic.Text = string.Empty;
            txtTopicRename.Text = string.Empty;
        }


    }
}
