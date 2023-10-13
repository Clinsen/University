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
    public partial class RealForm : Form
    {
        public RealForm()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RealNum realObj1 = new RealNum();
                realObj1.Get_Set_Real = Convert.ToDouble(inputTxt.Text);
                resultLbl.Text = realObj1.Calculate_norm().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something went wrong...");
            }
        }
    }
}
