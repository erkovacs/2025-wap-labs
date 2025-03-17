using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar3
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            var operand1Value = operand1.Text.ToString();
            var operand2Value = operand2.Text.ToString();
            var operationValue = operation.Text;

            try
            {
                double operand1Dbl = double.Parse(operand1Value);
                double operand2Dbl = double.Parse(operand2Value);

                double resultValue = 0.0d;
                  
                if (operationValue.Equals("+"))
                    resultValue = operand1Dbl + operand2Dbl;

                result.Text = resultValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
