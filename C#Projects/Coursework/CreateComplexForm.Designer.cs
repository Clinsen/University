namespace Coursework
{
    partial class CreateComplexForm
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
            label1 = new Label();
            label2 = new Label();
            nameTxt = new TextBox();
            realcValTxt = new TextBox();
            createObjBtn = new Button();
            label3 = new Label();
            ivalTxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 56);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Object name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 108);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 1;
            label2.Text = "Real value:";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(186, 53);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(150, 31);
            nameTxt.TabIndex = 2;
            // 
            // realcValTxt
            // 
            realcValTxt.Location = new Point(186, 105);
            realcValTxt.Name = "realcValTxt";
            realcValTxt.Size = new Size(150, 31);
            realcValTxt.TabIndex = 3;
            // 
            // createObjBtn
            // 
            createObjBtn.Location = new Point(101, 231);
            createObjBtn.Name = "createObjBtn";
            createObjBtn.Size = new Size(176, 34);
            createObjBtn.TabIndex = 4;
            createObjBtn.Text = "Create object";
            createObjBtn.UseVisualStyleBackColor = true;
            createObjBtn.Click += createObjBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 160);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 5;
            label3.Text = "Imaginary value:";
            // 
            // ivalTxt
            // 
            ivalTxt.Location = new Point(186, 157);
            ivalTxt.Name = "ivalTxt";
            ivalTxt.Size = new Size(150, 31);
            ivalTxt.TabIndex = 6;
            // 
            // CreateComplexForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 277);
            Controls.Add(ivalTxt);
            Controls.Add(label3);
            Controls.Add(createObjBtn);
            Controls.Add(realcValTxt);
            Controls.Add(nameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "CreateComplexForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create object";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTxt;
        private TextBox realcValTxt;
        private Button createObjBtn;
        private Label label3;
        private TextBox ivalTxt;
    }
}