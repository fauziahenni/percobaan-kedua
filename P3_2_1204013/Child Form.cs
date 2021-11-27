using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_2_1204013
{
    public partial class Child_Form : Form
    {
        private string outputText = DateTime.Now.ToString("d");
        public Child_Form()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputLbel.Text = outputText;
        }
        private void DateOpinion_ChekedChange(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }
        private void TimeOpinion_ChekedChange(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }
    }
}
