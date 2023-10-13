namespace Coursework
{
    partial class CreateForm
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
            realBtn = new Button();
            complexBtn = new Button();
            SuspendLayout();
            // 
            // realBtn
            // 
            realBtn.Location = new Point(12, 12);
            realBtn.Name = "realBtn";
            realBtn.Size = new Size(123, 83);
            realBtn.TabIndex = 0;
            realBtn.Text = "Real";
            realBtn.UseVisualStyleBackColor = true;
            realBtn.Click += realBtn_Click;
            // 
            // complexBtn
            // 
            complexBtn.Location = new Point(151, 12);
            complexBtn.Name = "complexBtn";
            complexBtn.Size = new Size(120, 83);
            complexBtn.TabIndex = 1;
            complexBtn.Text = "Complex";
            complexBtn.UseVisualStyleBackColor = true;
            complexBtn.Click += complexBtn_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 107);
            Controls.Add(complexBtn);
            Controls.Add(realBtn);
            MaximizeBox = false;
            Name = "CreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create object";
            ResumeLayout(false);
        }

        #endregion

        private Button realBtn;
        private Button complexBtn;
    }
}