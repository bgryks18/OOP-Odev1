using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t = 0;
        int l = 14;
        int kacbutton = 0;
        int btngenislik = 200;
        int btnyukseklik = 34;
        string[] butonlar = { "Masa", "Dumbell", "Ayakkabı", "Kulaklık", "Halı", "Kolonya", "Pantolon", "Çanta", "Atlama İpi", "Mousepad", "USB Kablo", "Flashbellek", "Çoklu priz", "Dolap", "Oyuncak ayı" };

        private void yaz(object sender, System.EventArgs e)
        {
            MessageBox.Show("asdasdasdasd");
        }

        void altabutonekle(string text, string hangibuton, int yan, bool yenigrup)
        {
            Button btn = new Button();

            btn.Text = text;
            btn.Height = btnyukseklik;
            btn.Width = btngenislik;
            btn.TextAlign = ContentAlignment.MiddleLeft;

            if (yenigrup == true)
            {
                t = 0;
            }
            btn.Top = t + btnyukseklik;
            btn.Left = l + (yan * btngenislik);

            btn.Name = hangibuton;
            t = t + btnyukseklik;

            this.Controls.Add(btn);
            kacbutton++;
            btn.Click += new EventHandler(b_Click);
        }

        private void b_Click(object sender, EventArgs e)
        {
            int kactane = butonlar.Length;
            string hangibuton = ((Button)sender).Name;
            for (int i = 0; i < kactane; i++)
            {
                if (hangibuton == ("b" + i))
                {
                    Form ff = new Form();
                    ff.Show();
                    string islem = butonlar[i].ToLower();
                    switch (islem)
                    {
                        case "masa":
                            TextBox txbox = new TextBox();
                            txbox.Name = "tx1";
                            ff.Controls.Add(txbox);
                            break;

                        case "dumbell":

                            break;

                        case "ayakkabı":

                            break;

                        case "kulaklık":

                            break;

                        case "halı":

                            break;

                        case "kolonya":

                            break;

                        case "pantolon":

                            break;

                        case "çanta":

                            break;

                        case "atlama ipi":

                            break;


                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    kacbutton++;
                }
            }
            bool yenigrup = false;
            for (int i = 0, yanagec = -1; i < 15; i++)
            {

                if (kacbutton % 5 == 0)
                {
                    yanagec++;
                    yenigrup = true;
                }
                else
                {
                    yenigrup = false;
                }
                altabutonekle(((i + 1) + ".) " + butonlar[i] + " nesnesi"), ("b" + i), yanagec, yenigrup);
            }
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    string buton = btn.Name;

                }
            }
        }
    }
}
