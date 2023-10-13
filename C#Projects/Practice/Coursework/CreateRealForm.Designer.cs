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
            objNameTxt.Location = new Point(190, 52);
            objNameTxt.Margin = new Padding(4, 5, 4, 5);
            objNameTxt.Name = "objNameTxt";
            objNameTxt.Size = new Size(141, 31);
            objNameTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 1;
            label1.Text = "Object name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 2;
            label2.Text = "Object value:";
            // 
            // objValTxt
            // 
            objValTxt.Location = new Point(190, 117);
            objValTxt.Margin = new Padding(4, 5, 4, 5);
            objValTxt.Name = "objValTxt";
            objValTxt.Size = new Size(141, 31);
            objValTxt.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(94, 207);
            createBtn.Margin = new Padding(4, 5, 4, 5);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(159, 38);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create object";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // CreateRealForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 265);
            Controls.Add(createBtn);
            Controls.Add(objValTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(objNameTxt);
            Margin = new Padding(4, 5, 4, 5);
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