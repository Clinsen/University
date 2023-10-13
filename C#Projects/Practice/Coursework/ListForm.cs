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
    public partial class ListForm : Form
    {
        List<int> numbers = new List<int>();
        int amount = 0;
        double norm = 0;

        public ListForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.TryParse(inputTxt.Text, out int converted) ? converted : 0;
                numbers.Add(number);
                listbox.Items.Add(number);
                inputTxt.Text = null;

                foreach (double num in numbers)
                {
                    norm += num;
                }

                norm = Math.Sqrt(norm);
                amount = numbers.Count();

                amountLbl.Text = $"Numbers amount: {amount}";
                normLbl.Text = $"Calculating norm: {norm}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you really want to clear your list?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                listbox.Items.Clear();
                numbers.Clear();
                amountLbl.Text = "Numbers amount:";
                normLbl.Text = "Calculating norm:";
            }
            else
            {
                return;
            }
        }
    }
}
