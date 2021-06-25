using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItogWork
{
    public partial class Form1 : Form
    {
        public static string sum;
        public static bool Clear = false;
        public static bool TrueClear = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Prosents_ValueChanged(object sender, EventArgs e)
        {
            Prosents.Maximum = 1;
            Prosents.Minimum = 0;
        }

        private void SrokZaima_ValueChanged(object sender, EventArgs e)
        {
            SrokZaima.Maximum = 365;
            SrokZaima.Minimum = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
                file.WriteLine(SumZaimInRub.Text);
                file.WriteLine(SrokZaima.Text);
                file.WriteLine(Prosents.Text);
                file.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear = false;
            sum = SumZaimInRub.Text + SumZaimInRub.Text;
            textRes.Text = sum;
        }
    }
}
