namespace Dev_Launcher
{
    partial class frmLauncher
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
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picCmd = new System.Windows.Forms.PictureBox();
            this.picStackoverflow = new System.Windows.Forms.PictureBox();
            this.picGit = new System.Windows.Forms.PictureBox();
            this.picVscode = new System.Windows.Forms.PictureBox();
            this.picVscommunity = new System.Windows.Forms.PictureBox();
            this.picIntellij = new System.Windows.Forms.PictureBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStackoverflow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVscode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVscommunity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntellij)).BeginInit();
            this.SuspendLayout();
            // 
            // picExit
            // 
            this.picExit.Image = global::Dev_Launcher.Properties.Resources.exit1;
            this.picExit.Location = new System.Drawing.Point(649, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(100, 100);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 6;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // picCmd
            // 
            this.picCmd.Image = global::Dev_Launcher.Properties.Resources.cmd;
            this.picCmd.Location = new System.Drawing.Point(543, 12);
            this.picCmd.Name = "picCmd";
            this.picCmd.Size = new System.Drawing.Size(100, 100);
            this.picCmd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCmd.TabIndex = 5;
            this.picCmd.TabStop = false;
            this.picCmd.Click += new System.EventHandler(this.picCmd_Click);
            // 
            // picStackoverflow
            // 
            this.picStackoverflow.Image = global::Dev_Launcher.Properties.Resources.stackoflow;
            this.picStackoverflow.Location = new System.Drawing.Point(437, 12);
            this.picStackoverflow.Name = "picStackoverflow";
            this.picStackoverflow.Size = new System.Drawing.Size(100, 100);
            this.picStackoverflow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStackoverflow.TabIndex = 4;
            this.picStackoverflow.TabStop = false;
            this.picStackoverflow.Click += new System.EventHandler(this.picStackoverflow_Click);
            // 
            // picGit
            // 
            this.picGit.Image = global::Dev_Launcher.Properties.Resources.git;
            this.picGit.Location = new System.Drawing.Point(331, 12);
            this.picGit.Name = "picGit";
            this.picGit.Size = new System.Drawing.Size(100, 100);
            this.picGit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGit.TabIndex = 3;
            this.picGit.TabStop = false;
            this.picGit.Click += new System.EventHandler(this.picGit_Click);
            // 
            // picVscode
            // 
            this.picVscode.Image = global::Dev_Launcher.Properties.Resources.vscode;
            this.picVscode.Location = new System.Drawing.Point(225, 12);
            this.picVscode.Name = "picVscode";
            this.picVscode.Size = new System.Drawing.Size(100, 100);
            this.picVscode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVscode.TabIndex = 2;
            this.picVscode.TabStop = false;
            this.picVscode.Click += new System.EventHandler(this.picVscode_Click);
            // 
            // picVscommunity
            // 
            this.picVscommunity.Image = global::Dev_Launcher.Properties.Resources.vs_com;
            this.picVscommunity.Location = new System.Drawing.Point(119, 12);
            this.picVscommunity.Name = "picVscommunity";
            this.picVscommunity.Size = new System.Drawing.Size(100, 100);
            this.picVscommunity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVscommunity.TabIndex = 1;
            this.picVscommunity.TabStop = false;
            this.picVscommunity.Click += new System.EventHandler(this.picVscommunity_Click);
            // 
            // picIntellij
            // 
            this.picIntellij.Image = global::Dev_Launcher.Properties.Resources.intellij;
            this.picIntellij.Location = new System.Drawing.Point(13, 12);
            this.picIntellij.Name = "picIntellij";
            this.picIntellij.Size = new System.Drawing.Size(100, 100);
            this.picIntellij.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIntellij.TabIndex = 0;
            this.picIntellij.TabStop = false;
            this.picIntellij.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(12, 128);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(213, 16);
            this.lblCopyRight.TabIndex = 7;
            this.lblCopyRight.Text = "Made with ❤️ by yarzardhiyit © 2022";
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 153);
            this.ControlBox = false;
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picCmd);
            this.Controls.Add(this.picStackoverflow);
            this.Controls.Add(this.picGit);
            this.Controls.Add(this.picVscode);
            this.Controls.Add(this.picVscommunity);
            this.Controls.Add(this.picIntellij);
            this.MaximizeBox = false;
            this.Name = "frmLauncher";
            this.Text = "DEV: Essential Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStackoverflow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVscode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVscommunity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntellij)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIntellij;
        private System.Windows.Forms.PictureBox picVscommunity;
        private System.Windows.Forms.PictureBox picGit;
        private System.Windows.Forms.PictureBox picVscode;
        private System.Windows.Forms.PictureBox picCmd;
        private System.Windows.Forms.PictureBox picStackoverflow;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblCopyRight;
    }
}

