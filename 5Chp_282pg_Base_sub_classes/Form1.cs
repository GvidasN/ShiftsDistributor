using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5Chp_282pg_Base_sub_classes
{
    public partial class Form1 : Form
    {
        Queen queen;
        Worker[] workers;
        int shifts = 1;
        public Form1()
        {
            InitializeComponent();

            workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" },1.75);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" },1.14);
            workers[2] = new Worker(new string[] { "Hive maintenance","Sting patrol" },1.49);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" , "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" },1.55);

            queen = new Queen(0,workers,2.75);
        }

        private void butAssignJ_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(comboBox1.Text, (int)numericUpDown1.Value)) MessageBox.Show("Job has been assigned!");
            else MessageBox.Show("All bees are busy or unable to do the task");
        }

        private void butNextShift_Click(object sender, EventArgs e)
        {
            double sum = 0;
            Report.Text = "report for shift #" + shifts.ToString() + "\r\n";
            sum += queen.HoneyConsumptionRate();
            for (int i = 0; i < 4; i++)
            {
                sum += workers[i].HoneyConsumptionRate();
                if (queen.WorkTheNextShift(i))
                {
                    Report.Text += "Worker #" + (i+1).ToString() + " is not working \r\n";
                }
                else Report.Text += "Worker #" + (i+1).ToString() + " is doing " + workers[i].CurrentJob + " for " + workers[i].ShiftsLeft + " more shifts\r\n";
            }
            Report.Text += "Total honey consumed for the shift: " + sum.ToString() + " units\r\n";
            shifts++;
        }

       
    }
}
