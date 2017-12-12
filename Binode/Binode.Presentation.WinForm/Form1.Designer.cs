namespace Binode.Presentation.WinForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grpKategori = new System.Windows.Forms.GroupBox();
            this.treeKategori = new System.Windows.Forms.TreeView();
            this.grpIcerik = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.metinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpKategori.SuspendLayout();
            this.grpIcerik.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKategori
            // 
            this.grpKategori.Controls.Add(this.treeKategori);
            this.grpKategori.Location = new System.Drawing.Point(16, 15);
            this.grpKategori.Margin = new System.Windows.Forms.Padding(4);
            this.grpKategori.Name = "grpKategori";
            this.grpKategori.Padding = new System.Windows.Forms.Padding(4);
            this.grpKategori.Size = new System.Drawing.Size(267, 529);
            this.grpKategori.TabIndex = 0;
            this.grpKategori.TabStop = false;
            this.grpKategori.Text = "Kategori";
            // 
            // treeKategori
            // 
            this.treeKategori.Location = new System.Drawing.Point(8, 23);
            this.treeKategori.Margin = new System.Windows.Forms.Padding(4);
            this.treeKategori.Name = "treeKategori";
            this.treeKategori.Size = new System.Drawing.Size(249, 498);
            this.treeKategori.TabIndex = 0;
            this.treeKategori.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeKategori_AfterSelect);
            // 
            // grpIcerik
            // 
            this.grpIcerik.Controls.Add(this.listView1);
            this.grpIcerik.Location = new System.Drawing.Point(291, 15);
            this.grpIcerik.Margin = new System.Windows.Forms.Padding(4);
            this.grpIcerik.Name = "grpIcerik";
            this.grpIcerik.Padding = new System.Windows.Forms.Padding(4);
            this.grpIcerik.Size = new System.Drawing.Size(755, 529);
            this.grpIcerik.TabIndex = 1;
            this.grpIcerik.TabStop = false;
            this.grpIcerik.Text = "İçerik";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(8, 23);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(737, 498);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategori";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 100);
            this.contextMenuStrip1.Text = "Yeniden Adlandır";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItem1.Text = "Yeniden Adlandır";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItem2.Text = "Alt Kategori Ekle...";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox2_KeyPress_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metinToolStripMenuItem,
            this.pdfToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.sesToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItem4.Text = "İçerik Ekle";
            // 
            // metinToolStripMenuItem
            // 
            this.metinToolStripMenuItem.Name = "metinToolStripMenuItem";
            this.metinToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.metinToolStripMenuItem.Text = "Metin";
            this.metinToolStripMenuItem.Click += new System.EventHandler(this.fileDialog);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pdfToolStripMenuItem.Text = "Pdf";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // sesToolStripMenuItem
            // 
            this.sesToolStripMenuItem.Name = "sesToolStripMenuItem";
            this.sesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sesToolStripMenuItem.Text = "Ses";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItem3.Text = "Sil";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 559);
            this.Controls.Add(this.grpIcerik);
            this.Controls.Add(this.grpKategori);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKategori.ResumeLayout(false);
            this.grpIcerik.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKategori;
        private System.Windows.Forms.TreeView treeKategori;
        private System.Windows.Forms.GroupBox grpIcerik;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem metinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

