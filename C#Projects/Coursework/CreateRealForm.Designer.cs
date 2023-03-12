namespace Coursework
{
    partial class CreateRealForm
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
            objNameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            objValTxt = new TextBox();
            createBtn = new Button();
            SuspendLayout();
            // 
            // objNameTxt
            // 
            objNameTxt.Location = new Point(133, 31);
            objNameTxt.Name = "objNameTxt";
            objNameTxt.Size = new Size(100, 23);
            objNameTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Object name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Object value:";
            // 
            // objValTxt
            // 
            objValTxt.Location = new Point(133, 70);
            objValTxt.Name = "objValTxt";
            objValTxt.Size = new Size(100, 23);
            objValTxt.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(66, 124);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(111, 23);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // CreateRealForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 159);
            Controls.Add(createBtn);
            Controls.Add(objValTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(objNameTxt);
            MaximizeBox = false;
            Name = "CreateRealForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create object";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox objNameTxt;
        private Label label1;
        private Label label2;
        private TextBox objValTxt;
        private Button createBtn;
    }
}