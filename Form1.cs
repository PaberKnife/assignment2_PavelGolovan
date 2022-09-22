using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2_PavelGolovan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                int costA = 15, costB = 12, costC = 9, countA, countB, countC, classA_total, classB_total, classC_total, total;

                countA = int.Parse(classA_textBox.Text);
                countB = int.Parse(classB_textBox.Text);
                countC = int.Parse(classC_textBox.Text);

                classA_total = countA * costA;
                classB_total = countB * costB;
                classC_total = countC * costC;
                total = classA_total + classB_total + classC_total;

                classAtotal_label.Text = classA_total.ToString("C");
                classBtotal_label.Text = classB_total.ToString("C");
                classCtotal_label.Text = classC_total.ToString("C");
                total_label1.Text = total.ToString("C");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            classA_textBox.Text = "";
            classB_textBox.Text = "";
            classC_textBox.Text = "";
            classAtotal_label.Text = "";
            classBtotal_label.Text = "";
            classCtotal_label.Text = "";
            total_label1.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
