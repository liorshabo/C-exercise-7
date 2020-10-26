using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Proj7
{
    public partial class Form1 : Form
    {
        ArrayList W = new ArrayList();
        int ticks = 0;
        int[] people;
        public Form1()
        {
            InitializeComponent();

            loading_file();
            timer1.Start();

        }

        public void loading_file()
        {
            string[] lines = File.ReadAllLines("worker.txt");
            people = new int[lines.Length];
            foreach (string item in lines)
            {
                string[] subs = item.Split('-');
                string[] numbers = subs[2].Split(':');
                W.Add(new Worker(subs[0], subs[1], int.Parse(numbers[0]), double.Parse(numbers[1])));
                comboBox.Items.Add(subs[0] + " " + subs[1]);
            }
        }

        private void num_shifts_Click(object sender, EventArgs e)
        {
            textBox1.Text="The number shift is: "+((Worker)W[comboBox.SelectedIndex]).Num_of_shifts;
            people[comboBox.SelectedIndex]++;
        }

        private void salary_sum_Click(object sender, EventArgs e)
        {
            textBox1.Text = "The salary is: " + ((Worker)W[comboBox.SelectedIndex]).Salary;
            people[comboBox.SelectedIndex]++;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            btn_exit.Enabled = false;
            btn_num_shifts.Enabled = false;
            btn_salary_sum.Enabled = false;
            comboBox.Enabled = false;
            timer1.Stop();
            MessageBox.Show("You used the program " + ticks+" seconds");
            for (int i = 0; i < people.Length; i++)
                if (people[i] != 0)
                    File.AppendAllText("Finish.txt", ((Worker)W[i]).ToString() + "\r\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
        }
    }
}
