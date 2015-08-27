namespace TutorialMgr
{
    partial class Topic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTopicRename = new System.Windows.Forms.TextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.cmbNumber = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.txtTopicRename, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTopic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbNumber, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTopicRename
            // 
            this.txtTopicRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTopicRename.Location = new System.Drawing.Point(248, 3);
            this.txtTopicRename.Name = "txtTopicRename";
            this.txtTopicRename.Size = new System.Drawing.Size(449, 20);
            this.txtTopicRename.TabIndex = 2;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(3, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(169, 35);
            this.lblTopic.TabIndex = 3;
            this.lblTopic.Text = "label1";
            // 
            // cmbNumber
            // 
            this.cmbNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbNumber.FormattingEnabled = true;
            this.cmbNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cmbNumber.Location = new System.Drawing.Point(206, 3);
            this.cmbNumber.Name = "cmbNumber";
            this.cmbNumber.Size = new System.Drawing.Size(36, 21);
            this.cmbNumber.TabIndex = 4;
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Topic";
            this.Size = new System.Drawing.Size(706, 61);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTopicRename;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.ComboBox cmbNumber;
    }
}
