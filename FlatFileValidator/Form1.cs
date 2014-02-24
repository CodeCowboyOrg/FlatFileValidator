using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FlatFileValidator.Parser;

namespace FlatFileValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileReader fr = new FileReader(@"C:\Users\Johnny\Desktop\GEONAMES2013\allCountries\allCountries.txt");
            fr.Process();
            MessageBox.Show(fr.LineCount.ToString());

        }
    }
}
