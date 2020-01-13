namespace HigurashiDaybreakConfig
{
    partial class FormMyConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMyConf));
            this.txtGameFolder = new System.Windows.Forms.TextBox();
            this.lblGameFolder = new System.Windows.Forms.Label();
            this.btnBrowseGameFolder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGameFolder
            // 
            this.txtGameFolder.Location = new System.Drawing.Point(89, 10);
            this.txtGameFolder.Name = "txtGameFolder";
            this.txtGameFolder.Size = new System.Drawing.Size(283, 20);
            this.txtGameFolder.TabIndex = 0;
            // 
            // lblGameFolder
            // 
            this.lblGameFolder.AutoSize = true;
            this.lblGameFolder.Location = new System.Drawing.Point(13, 13);
            this.lblGameFolder.Name = "lblGameFolder";
            this.lblGameFolder.Size = new System.Drawing.Size(70, 13);
            this.lblGameFolder.TabIndex = 1;
            this.lblGameFolder.Text = "Game Folder:";
            // 
            // btnBrowseGameFolder
            // 
            this.btnBrowseGameFolder.Location = new System.Drawing.Point(378, 8);
            this.btnBrowseGameFolder.Name = "btnBrowseGameFolder";
            this.btnBrowseGameFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseGameFolder.TabIndex = 2;
            this.btnBrowseGameFolder.Text = "Browse";
            this.btnBrowseGameFolder.UseVisualStyleBackColor = true;
            this.btnBrowseGameFolder.Click += new System.EventHandler(this.btnBrowseGameFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(437, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMyConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 100);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseGameFolder);
            this.Controls.Add(this.lblGameFolder);
            this.Controls.Add(this.txtGameFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMyConf";
            this.Text = "Launcher Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameFolder;
        private System.Windows.Forms.Label lblGameFolder;
        private System.Windows.Forms.Button btnBrowseGameFolder;
        private System.Windows.Forms.Button btnSave;
    }
}