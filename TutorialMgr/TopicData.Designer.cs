namespace TutorialMgr
{
    partial class TopicData
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTopicCaption = new System.Windows.Forms.TextBox();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.txtTopicCaption);
            this.flowLayoutPanel1.Controls.Add(this.tblLayout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(685, 689);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // txtTopicCaption
            // 
            this.txtTopicCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTopicCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopicCaption.Location = new System.Drawing.Point(3, 3);
            this.txtTopicCaption.Name = "txtTopicCaption";
            this.txtTopicCaption.Size = new System.Drawing.Size(679, 26);
            this.txtTopicCaption.TabIndex = 1;
            // 
            // tblLayout
            // 
            this.tblLayout.AutoSize = true;
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblLayout.Location = new System.Drawing.Point(3, 35);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayout.Size = new System.Drawing.Size(0, 0);
            this.tblLayout.TabIndex = 2;
            // 
            // TopicData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TopicData";
            this.Size = new System.Drawing.Size(685, 689);
            this.Load += new System.EventHandler(this.TopicData_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtTopicCaption;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
    }
}
