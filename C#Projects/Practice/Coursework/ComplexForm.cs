using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class ComplexForm : Form
    {
        public ComplexForm()
        {
            InitializeComponent();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Complex complexObj = new Complex();
                complexObj.Get_Set_Ival = Convert.ToDouble(imaginaryTxt.Text);
                complexObj.Get_Set_Real = Convert.ToDouble(realTxt.Text);
                resultLbl.Text = complexObj.Calculate_norm().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something went wrong...");
            }
        }
    }
}
