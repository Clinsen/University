namespace Coursework
{
    partial class ListForm
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
            inputTxt = new TextBox();
            addBtn = new Button();
            listbox = new ListBox();
            amountLbl = new Label();
            normLbl = new Label();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // inputTxt
            // 
            inputTxt.Location = new Point(36, 27);
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(100, 23);
            inputTxt.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(155, 12);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // listbox
            // 
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 15;
            listbox.Location = new Point(36, 69);
            listbox.Name = "listbox";
            listbox.Size = new Size(195, 169);
            listbox.TabIndex = 2;
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Location = new Point(36, 254);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(104, 15);
            amountLbl.TabIndex = 3;
            amountLbl.Text = "Numbers amount:";
            // 
            // normLbl
            // 
            normLbl.AutoSize = true;
            normLbl.Location = new Point(38, 282);
            normLbl.Name = "normLbl";
            normLbl.Size = new Size(102, 15);
            normLbl.TabIndex = 4;
            normLbl.Text = "Calculating norm:";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(155, 40);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 313);
            Controls.Add(clearBtn);
            Controls.Add(normLbl);
            Controls.Add(amountLbl);
            Controls.Add(listbox);
            Controls.Add(addBtn);
            Controls.Add(inputTxt);
            MaximizeBox = false;
            Name = "ListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a list";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTxt;
        private Button addBtn;
        private ListBox listbox;
        private Label normLbl;
        private Label amountLbl;
        private Button clearBtn;
    }
}