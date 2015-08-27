namespace TutorialMgr
{
    partial class TutorialMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCurrentCourseFld = new System.Windows.Forms.Label();
            this.panTopicsData = new System.Windows.Forms.Panel();
            this.btnProcess = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkExtension = new System.Windows.Forms.CheckBox();
            this.chkCourse = new System.Windows.Forms.CheckBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblErrorCaption = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(136, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(774, 20);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.Text = "C:\\Downloads\\The MVC Request Life Cycle";
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(133, 45);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course";
            // 
            // lblCurrentCourseFld
            // 
            this.lblCurrentCourseFld.AutoSize = true;
            this.lblCurrentCourseFld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCourseFld.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrentCourseFld.Location = new System.Drawing.Point(195, 43);
            this.lblCurrentCourseFld.Name = "lblCurrentCourseFld";
            this.lblCurrentCourseFld.Size = new System.Drawing.Size(71, 20);
            this.lblCurrentCourseFld.TabIndex = 3;
            this.lblCurrentCourseFld.Text = "Nothing";
            // 
            // panTopicsData
            // 
            this.panTopicsData.AutoScroll = true;
            this.panTopicsData.Location = new System.Drawing.Point(12, 81);
            this.panTopicsData.Name = "panTopicsData";
            this.panTopicsData.Size = new System.Drawing.Size(912, 451);
            this.panTopicsData.TabIndex = 4;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 40);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bulk Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkExtension
            // 
            this.chkExtension.AutoSize = true;
            this.chkExtension.Checked = true;
            this.chkExtension.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExtension.Location = new System.Drawing.Point(688, 45);
            this.chkExtension.Name = "chkExtension";
            this.chkExtension.Size = new System.Drawing.Size(98, 17);
            this.chkExtension.TabIndex = 7;
            this.chkExtension.Text = "Add \".mov\" ext";
            this.chkExtension.UseVisualStyleBackColor = true;
            // 
            // chkCourse
            // 
            this.chkCourse.AutoSize = true;
            this.chkCourse.Location = new System.Drawing.Point(803, 45);
            this.chkCourse.Name = "chkCourse";
            this.chkCourse.Size = new System.Drawing.Size(99, 17);
            this.chkCourse.TabIndex = 8;
            this.chkCourse.Text = "Append Course";
            this.chkCourse.UseVisualStyleBackColor = true;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorMessage.Location = new System.Drawing.Point(3, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lblErrorMessage);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(125, 573);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(788, 120);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // lblErrorCaption
            // 
            this.lblErrorCaption.AutoSize = true;
            this.lblErrorCaption.Location = new System.Drawing.Point(122, 557);
            this.lblErrorCaption.Name = "lblErrorCaption";
            this.lblErrorCaption.Size = new System.Drawing.Size(40, 13);
            this.lblErrorCaption.TabIndex = 11;
            this.lblErrorCaption.Text = "Errors:-";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 596);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TutorialMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 734);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblErrorCaption);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chkCourse);
            this.Controls.Add(this.chkExtension);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.panTopicsData);
            this.Controls.Add(this.lblCurrentCourseFld);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Name = "TutorialMain";
            this.Text = "Tutorial Master";
            this.Load += new System.EventHandler(this.TutorialMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCurrentCourseFld;
        private System.Windows.Forms.Panel panTopicsData;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkExtension;
        private System.Windows.Forms.CheckBox chkCourse;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblErrorCaption;
        private System.Windows.Forms.Button btnRefresh;
    }
}

