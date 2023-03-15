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
    public partial class CreateComplexForm : Form
    {
        public CreateComplexForm()
        {
            InitializeComponent();
        }

        private void createObjBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectListForm yepyep = new ObjectListForm();
                yepyep.receiveComplexData(double.Parse(realcValTxt.Text), double.Parse(ivalTxt.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please carefully review the error message below:\n\n" + ex, "Something went wrong...");
            }
            this.Close();
        }
    }
}
