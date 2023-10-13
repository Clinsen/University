namespace Coursework
{
    partial class RealForm
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
            inputLbl = new Label();
            inputTxt = new TextBox();
            calculateBtn = new Button();
            resultLbl = new Label();
            randomLbl = new Label();
            SuspendLayout();
            // 
            // inputLbl
            // 
            inputLbl.AutoSize = true;
            inputLbl.Location = new Point(12, 38);
            inputLbl.Name = "inputLbl";
            inputLbl.Size = new Size(268, 25);
            inputLbl.TabIndex = 0;
            inputLbl.Text = "Enter the value of a real number:";
            // 
            // inputTxt
            // 
            inputTxt.Location = new Point(286, 35);
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(131, 31);
            inputTxt.TabIndex = 1;
            // 
            // calculateBtn
            // 
            calculateBtn.Cursor = Cursors.Hand;
            calculateBtn.Location = new Point(133, 159);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(177, 34);
            calculateBtn.TabIndex = 2;
            calculateBtn.Text = "Calculate norm!";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(239, 103);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(0, 25);
            resultLbl.TabIndex = 3;
            // 
            // randomLbl
            // 
            randomLbl.AutoSize = true;
            randomLbl.Location = new Point(170, 103);
            randomLbl.Name = "randomLbl";
            randomLbl.Size = new Size(63, 25);
            randomLbl.TabIndex = 4;
            randomLbl.Text = "Result:";
            // 
            // RealForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 205);
            Controls.Add(randomLbl);
            Controls.Add(resultLbl);
            Controls.Add(calculateBtn);
            Controls.Add(inputTxt);
            Controls.Add(inputLbl);
            MaximizeBox = false;
            Name = "RealForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculate Real";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inputLbl;
        private TextBox inputTxt;
        private Button calculateBtn;
        private Label resultLbl;
        private Label randomLbl;
    }
}