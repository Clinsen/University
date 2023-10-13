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
    public partial class CreateRealForm : Form
    {
        public CreateRealForm()
        {
            InitializeComponent();
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectListForm yep = new ObjectListForm();
                yep.receiveData(int.Parse(objValTxt.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please carefully review the error message below:\n\n" + ex, "Something went wrong...");
            }
            this.Close();
        }
    }
}
