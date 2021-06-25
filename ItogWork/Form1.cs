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
        public Form1()
        {
            InitializeComponent();
        }

        private void Prosents_ValueChanged(object sender, EventArgs e)
        {
            Prosents.Maximum = 1;
            Prosents.Minimum = 0;
        }
    }
}
