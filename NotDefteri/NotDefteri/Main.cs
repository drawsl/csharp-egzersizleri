using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NotDefteri
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Txt Dosyası | *.txt";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTxt.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Dosyası | *.txt | Word Dosyası | *.docx";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTxt.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTxt.Text, richTxt.Font, Brushes.Black, new Point(100, 100));

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Copy();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Cut();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTxt.Paste();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form hakkindaForm = new Hakkinda();
            hakkindaForm.Show();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTxt.Font = fd.Font;
            }
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                richTxt.ForeColor = cd.Color;
        }

        private void seçilenMetninRenginiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                richTxt.SelectionColor = cd.Color;

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
                this.ControlBox = false;
            else
                this.ControlBox = true;
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == true)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            }
            else
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            }
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTxt.Copy();
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTxt.Cut();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTxt.Paste();

        }

        private void seçiliRengiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                richTxt.SelectionColor = cd.Color;

        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


        }

        private void simgeDurumunaKçültToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void ekranaOrtalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
