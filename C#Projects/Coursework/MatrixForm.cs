using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class MatrixForm : Form
    {
        static int abs_value = 0;
        public MatrixForm()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                matrixDataGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Random rnd = new Random();

                int height = int.TryParse(rowsTxt.Text, out height) ? height : 0;
                int width = int.TryParse(colsTxt.Text, out width) ? width : 0;

                this.matrixDataGrid.ColumnCount = width;

                for (int i = 0; i < height; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(this.matrixDataGrid);

                    for (int j = 0; j < width; j++)
                    {
                        row.Cells[j].Value = rnd.Next(-10000, 10000);

                        if (abs_value < Math.Abs(Convert.ToInt32(row.Cells[j].Value)))
                        {
                            abs_value = Math.Abs(Convert.ToInt32(row.Cells[j].Value));
                            resultLbl.Text = $"Largest absolute value of the number in your matrix: {abs_value}";
                        }
                    }

                    this.matrixDataGrid.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong...\n\n", ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.matrixDataGrid.DataSource = null;
            this.matrixDataGrid.Rows.Clear();
            this.matrixDataGrid.Columns.Clear();
            resultLbl.Text = "Largest absolute value of the number in your matrix:";
        }
    }
}
