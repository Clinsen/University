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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void realBtn_Click(object sender, EventArgs e)
        {
            CreateRealForm one = new CreateRealForm();
            one.ShowDialog();
            this.Close();
        }

        private void complexBtn_Click(object sender, EventArgs e)
        {
            CreateComplexForm two = new CreateComplexForm();
            two.ShowDialog();
            this.Close();
        }
    }
}
