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

        private void Form1_Load(object sender, EventArgs e)
        {
            masa masa1 = new masa();

            masa1.genislik = 24.4;
            masa1.yukseklik = 23.4;
            string format = string.Format("Yükekliği: {0}, Genişliği: {1}",masa1.yukseklik,masa1.genislik);
            MessageBox.Show(format);
        }
    }
}
