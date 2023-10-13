using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class ObjectListForm : Form
    {
        static List<object> objList = new List<object>();
        BindingSource objListBindingSource = new BindingSource();

        public ObjectListForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CreateForm form = new CreateForm();
            form.ShowDialog();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Do you really want to clear your list?", "Confirm", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    objList.Clear();
                    objListBindingSource.ResetBindings(false);
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please carefully review the error message below:\n\n" + ex, "Something went wrong...");
            }
        }

        private void ObjectListForm_Load(object sender, EventArgs e)
        {
            objListBindingSource.DataSource = objList;
            listboxobj.DataSource = objListBindingSource;
        }

        internal void receiveData(int v)
        {
            RealNum objNameTxt = new RealNum(v);
            objList.Add(objNameTxt.Calculate_norm());
        }

        internal void receiveComplexData(double r, double v)
        {
            Complex nameTxt = new Complex(r, v);
            objList.Add(nameTxt.Calculate_norm());
        }

        private void ObjectListForm_Activated(object sender, EventArgs e)
        {
            objListBindingSource.ResetBindings(false);
        }
    }
}
