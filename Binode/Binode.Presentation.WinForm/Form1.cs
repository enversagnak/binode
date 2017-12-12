using Binode.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binode.Presentation.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Kategori> kategoriler;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kategoriler = DemoData.DemoKategoriGetir();
            KategoriyiTreeviewAEkle(kategoriler, null);
        }

        private void KategoriyiTreeviewAEkle(List<Kategori> kategoriler, TreeNode node)
        {
            foreach (var kategori in kategoriler)
            {
                if (node is null)
                {
                    var nnode = new TreeNode(kategori.Isim);
                    nnode.ContextMenuStrip = contextMenuStrip1;
                    treeKategori.Nodes.Add(nnode);
                    nnode.Tag = kategori;

                    if (kategori.AltKategori != null)
                    {
                        KategoriyiTreeviewAEkle(kategori.AltKategori, nnode);
                    }
                }
                else
                {
                    var nnode = node.Nodes.Add(kategori.Isim);
                    nnode.ContextMenuStrip = contextMenuStrip1;

                    nnode.Tag = kategori;
                    if (kategori.AltKategori != null)
                    {
                        KategoriyiTreeviewAEkle(kategori.AltKategori, nnode);
                    }
                }
            }

        }

        private void treeKategori_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();

            ListViewDoldur(e.Node);
        }

        private void ListViewDoldur(TreeNode node)
        {
            var kategori = node.Tag as Kategori;

            //Hatalı olabilir
            if (kategori?.Icerik?.Count == null)
            {
                return;
            }

            var group = new ListViewGroup();
            group.Name = kategori.Isim;
            group.Header = kategori.Isim;

            listView1.Groups.Add(group);
            foreach (var icerik in kategori.Icerik)
            {
                var li = new ListViewItem(new[] { icerik.Isim, kategori.Isim });
                li.Group = group;
                listView1.Items.Add(li);
            }

            //listView1.Groups.Add(group);

            if (node.Nodes != null)
            {
                foreach (TreeNode subNode in node.Nodes)
                {
                    ListViewDoldur(subNode);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                treeKategori.SelectedNode.Text = ((ToolStripTextBox)sender).Text;

            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            treeKategori.SelectedNode.Remove();
        }


        private void toolStripTextBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                var secilikategori = (Kategori)treeKategori.SelectedNode.Tag;
                secilikategori.AltKategori.Add(new Kategori
                {
                    Isim = ((ToolStripTextBox)sender).Text,
                    SiraNumarasi = secilikategori.AltKategori.Count,
                    EklenmeTarihi = DateTime.Now,
                    AciklamaNotu = (((ToolStripTextBox)sender).Text).ToString() + " dersine ait notlar",
                    UstKategori = secilikategori

                });
                treeKategori.Nodes.Clear();
                KategoriyiTreeviewAEkle(kategoriler, null);
            }

        }
        private void fileDialog(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            var icerik = ((ToolStripMenuItem)sender).Text;
            switch (icerik)
            {
                case "Metin":
                    openfile.Filter = "Text Dosyası |*.txt|Word Dosyası |*.docx";
                    break;
                case "Pdf":
                    openfile.Filter = "Pdf Dosyası |*.pdf";
                    break;
                case "Gorsel":
                    openfile.Filter = "Resim Dosyası |*.jpg;*.png";
                    break;
                case "Ses":
                    openfile.Filter = "Ses Dosyası |*.mp3;*.wav";
                    break;
                case "Video":
                    openfile.Filter = "Video Dosyası |*.wmp;*.mp4";
                    break;
            }
            if (DialogResult.OK == openfile.ShowDialog())
            {
                Kategori secilikategori = treeKategori.SelectedNode.Tag as Kategori;
                secilikategori.Icerik.Add(new Icerik
                {
                    Isim = openfile.FileName,
                    EklenmeTarihi = DateTime.Now,
                    Kategori = secilikategori
                });
            };
        }
    }
}
