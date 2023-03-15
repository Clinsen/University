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
            listboxobj = new ListBox();
            createBtn = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // listboxobj
            // 
            listboxobj.FormattingEnabled = true;
            listboxobj.ItemHeight = 25;
            listboxobj.Location = new Point(17, 217);
            listboxobj.Margin = new Padding(4, 5, 4, 5);
            listboxobj.Name = "listboxobj";
            listboxobj.Size = new Size(294, 304);
            listboxobj.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(17, 20);
            createBtn.Margin = new Padding(4, 5, 4, 5);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(296, 138);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create an object";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(17, 168);
            clearBtn.Margin = new Padding(4, 5, 4, 5);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(296, 38);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // ObjectListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 567);
            Controls.Add(clearBtn);
            Controls.Add(createBtn);
            Controls.Add(listboxobj);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "ObjectListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object list";
            Activated += ObjectListForm_Activated;
            Load += ObjectListForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button createBtn;
        private Button clearBtn;
        private ListBox listboxobj;
    }
}