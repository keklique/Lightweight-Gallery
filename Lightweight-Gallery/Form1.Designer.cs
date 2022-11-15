
namespace Lightweight_Gallery
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.imageView1 = new Lightweight_Gallery.ImageView();
            this.folderSelection1 = new Lightweight_Gallery.FolderSelection();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.imageView1);
            this.panelMain.Controls.Add(this.folderSelection1);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(954, 515);
            this.panelMain.TabIndex = 0;
            // 
            // imageView1
            // 
            this.imageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageView1.Location = new System.Drawing.Point(110, 0);
            this.imageView1.Name = "imageView1";
            this.imageView1.Size = new System.Drawing.Size(844, 515);
            this.imageView1.TabIndex = 2;
            this.imageView1.Visible = false;
            // 
            // folderSelection1
            // 
            this.folderSelection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderSelection1.Location = new System.Drawing.Point(110, 0);
            this.folderSelection1.Name = "folderSelection1";
            this.folderSelection1.form1 = this;
            this.folderSelection1.Size = new System.Drawing.Size(844, 515);
            this.folderSelection1.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(110, 515);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "main-menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 515);
            this.Controls.Add(this.panelMain);
            this.Name = "Main";
            this.Text = "Leightweight Gallery";
            this.panelMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private FolderSelection folderSelection1;
        private ImageView imageView1;
    }
}

