namespace Coursework
{
    partial class MatrixForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            matrixDataGrid = new DataGridView();
            rowsLbl = new Label();
            colsLbl = new Label();
            rowsTxt = new TextBox();
            colsTxt = new TextBox();
            generateBtn = new Button();
            clearBtn = new Button();
            resultLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)matrixDataGrid).BeginInit();
            SuspendLayout();
            // 
            // matrixDataGrid
            // 
            matrixDataGrid.AllowUserToAddRows = false;
            matrixDataGrid.AllowUserToDeleteRows = false;
            matrixDataGrid.AllowUserToResizeColumns = false;
            matrixDataGrid.AllowUserToResizeRows = false;
            matrixDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixDataGrid.ColumnHeadersVisible = false;
            matrixDataGrid.GridColor = SystemColors.ActiveCaptionText;
            matrixDataGrid.Location = new Point(12, 106);
            matrixDataGrid.Name = "matrixDataGrid";
            matrixDataGrid.RowHeadersVisible = false;
            matrixDataGrid.RowTemplate.Height = 25;
            matrixDataGrid.Size = new Size(393, 346);
            matrixDataGrid.TabIndex = 0;
            // 
            // rowsLbl
            // 
            rowsLbl.AutoSize = true;
            rowsLbl.Location = new Point(28, 29);
            rowsLbl.Name = "rowsLbl";
            rowsLbl.Size = new Size(96, 15);
            rowsLbl.TabIndex = 1;
            rowsLbl.Text = "Number of rows:";
            // 
            // colsLbl
            // 
            colsLbl.AutoSize = true;
            colsLbl.Location = new Point(28, 69);
            colsLbl.Name = "colsLbl";
            colsLbl.Size = new Size(117, 15);
            colsLbl.TabIndex = 2;
            colsLbl.Text = "Number of columns:";
            // 
            // rowsTxt
            // 
            rowsTxt.Location = new Point(151, 26);
            rowsTxt.Name = "rowsTxt";
            rowsTxt.Size = new Size(39, 23);
            rowsTxt.TabIndex = 3;
            // 
            // colsTxt
            // 
            colsTxt.Location = new Point(151, 66);
            colsTxt.Name = "colsTxt";
            colsTxt.Size = new Size(39, 23);
            colsTxt.TabIndex = 4;
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(213, 26);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(94, 23);
            generateBtn.TabIndex = 5;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(213, 66);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 23);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(28, 462);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(283, 15);
            resultLbl.TabIndex = 7;
            resultLbl.Text = "Largest absolute value of the number in your matrix:";
            // 
            // MatrixForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 486);
            Controls.Add(resultLbl);
            Controls.Add(clearBtn);
            Controls.Add(generateBtn);
            Controls.Add(colsTxt);
            Controls.Add(rowsTxt);
            Controls.Add(colsLbl);
            Controls.Add(rowsLbl);
            Controls.Add(matrixDataGrid);
            Name = "MatrixForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a matrix";
            ((System.ComponentModel.ISupportInitialize)matrixDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView matrixDataGrid;
        private Label rowsLbl;
        private Label colsLbl;
        private TextBox rowsTxt;
        private TextBox colsTxt;
        private Button generateBtn;
        private Button clearBtn;
        private Label resultLbl;
    }
}