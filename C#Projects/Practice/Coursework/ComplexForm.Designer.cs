namespace Coursework
{
    partial class ComplexForm
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
            realLbl = new Label();
            imaginaryLbl = new Label();
            realTxt = new TextBox();
            imaginaryTxt = new TextBox();
            resultLbl = new Label();
            calculate_btn = new Button();
            randomLbl = new Label();
            SuspendLayout();
            // 
            // realLbl
            // 
            realLbl.AutoSize = true;
            realLbl.Location = new Point(45, 24);
            realLbl.Name = "realLbl";
            realLbl.Size = new Size(89, 25);
            realLbl.TabIndex = 0;
            realLbl.Text = "Enter real:";
            // 
            // imaginaryLbl
            // 
            imaginaryLbl.AutoSize = true;
            imaginaryLbl.Location = new Point(27, 87);
            imaginaryLbl.Name = "imaginaryLbl";
            imaginaryLbl.Size = new Size(139, 25);
            imaginaryLbl.TabIndex = 1;
            imaginaryLbl.Text = "Enter imaginary:";
            // 
            // realTxt
            // 
            realTxt.Location = new Point(188, 24);
            realTxt.Name = "realTxt";
            realTxt.Size = new Size(150, 31);
            realTxt.TabIndex = 2;
            // 
            // imaginaryTxt
            // 
            imaginaryTxt.Location = new Point(188, 84);
            imaginaryTxt.Name = "imaginaryTxt";
            imaginaryTxt.Size = new Size(150, 31);
            imaginaryTxt.TabIndex = 3;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(184, 145);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(0, 25);
            resultLbl.TabIndex = 4;
            // 
            // calculate_btn
            // 
            calculate_btn.Location = new Point(72, 187);
            calculate_btn.Name = "calculate_btn";
            calculate_btn.Size = new Size(236, 34);
            calculate_btn.TabIndex = 5;
            calculate_btn.Text = "Calculate norm!";
            calculate_btn.UseVisualStyleBackColor = true;
            calculate_btn.Click += calculate_btn_Click;
            // 
            // randomLbl
            // 
            randomLbl.AutoSize = true;
            randomLbl.Location = new Point(124, 145);
            randomLbl.Name = "randomLbl";
            randomLbl.Size = new Size(63, 25);
            randomLbl.TabIndex = 6;
            randomLbl.Text = "Result:";
            // 
            // ComplexForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 242);
            Controls.Add(randomLbl);
            Controls.Add(calculate_btn);
            Controls.Add(resultLbl);
            Controls.Add(imaginaryTxt);
            Controls.Add(realTxt);
            Controls.Add(imaginaryLbl);
            Controls.Add(realLbl);
            MaximizeBox = false;
            Name = "ComplexForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate complex";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label realLbl;
        private Label imaginaryLbl;
        private TextBox realTxt;
        private TextBox imaginaryTxt;
        private Label resultLbl;
        private Button calculate_btn;
        private Label randomLbl;
    }
}