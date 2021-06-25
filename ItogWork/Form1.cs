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
		public double fullSum = 0;
		public double pereplata = 0;
		public double srRpocent;
		public static string summ;
		////public static bool Clear = false;
		////public static bool TrueClear = false;
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
			////Clear = false;
			//double sumzaim = Convert.ToDouble(SumZaimInRub.Text);
			//double pros = Convert.ToDouble(Prosents.Text);
			//double srokk = Convert.ToDouble(SrokZaima.Text);
			//double v = sumzaim + (sumzaim / pros) * srokk;
			//string res = Convert.ToString(v);
			//textRes.Text = res;

			bool right = true;
			string[] daysandprocent;

				try
				{
					int x = Convert.ToInt32(SumZaimInRub.Text);
					int y = Convert.ToInt32(SrokZaima.Text);
				}
				catch (FormatException)
				{
					MessageBox.Show("Неверно веденны данные");
				}

			if (SumZaimInRub.Text == "" || SrokZaima.Text == "" || (Convert.ToInt32(SumZaimInRub.Text) > 500000 ))
			{
				right = false;
				MessageBox.Show("Неверно веденны данные");
			}

			if (right)
			{
				daysandprocent = Prosents.Text.Split(' ');

				int sumZaima = Convert.ToInt32(SumZaimInRub.Text);
				double[] procentDay = new double[Convert.ToInt32(SrokZaima.Text)];

				///// проценты по умолчанию 
				for (int i = 0; i < procentDay.Length; i++) 
				{
					procentDay[i] = 0.9;
				}

				/////переплата
				for (int i = 0; i < procentDay.Length; i++)
				{
					pereplata += sumZaima / 100 * procentDay[i];
				}


				////
				double sumProcent = 0;
				for (int i = 0; i < procentDay.Length; i++)
				{
					sumProcent += procentDay[i];
				}

				fullSum = sumZaima + pereplata;
				srRpocent = sumProcent / procentDay.Length;

				DialogResult dialogResult = MessageBox.Show("Полная выплачиваемая сумма: " + fullSum + "\n" + "Сумма процентов по долгу: " + pereplata + "\n" + "Эффективная процентная ставка в день: " + srRpocent);
			}
		}

		private void textRes_TextChanged(object sender, EventArgs e)
		{

		}
	}
}

