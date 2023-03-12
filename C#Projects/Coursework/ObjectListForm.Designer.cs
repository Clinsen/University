namespace Coursework
{
    partial class ObjectListForm
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
            listbox = new ListBox();
            createBtn = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // listbox
            // 
            listbox.FormattingEnabled = true;
            listbox.ItemHeight = 15;
            listbox.Location = new Point(12, 130);
            listbox.Name = "listbox";
            listbox.Size = new Size(207, 184);
            listbox.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(12, 12);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(207, 83);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create an object";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(12, 101);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(207, 23);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // ObjectListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 340);
            Controls.Add(clearBtn);
            Controls.Add(createBtn);
            Controls.Add(listbox);
            MaximizeBox = false;
            Name = "ObjectListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object list";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listbox;
        private Button createBtn;
        private Button clearBtn;
    }
}