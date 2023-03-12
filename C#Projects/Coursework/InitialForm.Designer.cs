namespace Coursework
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            create_real_btn = new Button();
            create_complex_btn = new Button();
            create_list_btn = new Button();
            create_matrix_btn = new Button();
            create_obj_list_btn = new Button();
            show_faq_btn = new Button();
            SuspendLayout();
            // 
            // create_real_btn
            // 
            create_real_btn.Location = new Point(28, 11);
            create_real_btn.Margin = new Padding(2);
            create_real_btn.Name = "create_real_btn";
            create_real_btn.Size = new Size(190, 29);
            create_real_btn.TabIndex = 0;
            create_real_btn.Text = "Create a real number";
            create_real_btn.UseVisualStyleBackColor = true;
            create_real_btn.Click += create_real_btn_Click;
            // 
            // create_complex_btn
            // 
            create_complex_btn.Location = new Point(28, 44);
            create_complex_btn.Margin = new Padding(2);
            create_complex_btn.Name = "create_complex_btn";
            create_complex_btn.Size = new Size(190, 28);
            create_complex_btn.TabIndex = 1;
            create_complex_btn.Text = "Create a complex number";
            create_complex_btn.UseVisualStyleBackColor = true;
            create_complex_btn.Click += create_complex_btn_Click;
            // 
            // create_list_btn
            // 
            create_list_btn.Location = new Point(28, 76);
            create_list_btn.Margin = new Padding(2);
            create_list_btn.Name = "create_list_btn";
            create_list_btn.Size = new Size(190, 25);
            create_list_btn.TabIndex = 2;
            create_list_btn.Text = "Create a list";
            create_list_btn.UseVisualStyleBackColor = true;
            create_list_btn.Click += create_list_btn_Click;
            // 
            // create_matrix_btn
            // 
            create_matrix_btn.Location = new Point(28, 135);
            create_matrix_btn.Margin = new Padding(2);
            create_matrix_btn.Name = "create_matrix_btn";
            create_matrix_btn.Size = new Size(190, 25);
            create_matrix_btn.TabIndex = 3;
            create_matrix_btn.Text = "Create a matrix";
            create_matrix_btn.UseVisualStyleBackColor = true;
            create_matrix_btn.Click += create_matrix_btn_Click;
            // 
            // create_obj_list_btn
            // 
            create_obj_list_btn.Location = new Point(28, 105);
            create_obj_list_btn.Margin = new Padding(2);
            create_obj_list_btn.Name = "create_obj_list_btn";
            create_obj_list_btn.Size = new Size(190, 26);
            create_obj_list_btn.TabIndex = 4;
            create_obj_list_btn.Text = "Create a list of objects";
            create_obj_list_btn.UseVisualStyleBackColor = true;
            create_obj_list_btn.Click += create_obj_list_btn_Click;
            // 
            // show_faq_btn
            // 
            show_faq_btn.Location = new Point(28, 164);
            show_faq_btn.Margin = new Padding(2);
            show_faq_btn.Name = "show_faq_btn";
            show_faq_btn.Size = new Size(190, 26);
            show_faq_btn.TabIndex = 5;
            show_faq_btn.Text = "Show FAQ";
            show_faq_btn.UseVisualStyleBackColor = true;
            show_faq_btn.Click += show_faq_btn_Click;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(246, 200);
            Controls.Add(show_faq_btn);
            Controls.Add(create_obj_list_btn);
            Controls.Add(create_matrix_btn);
            Controls.Add(create_list_btn);
            Controls.Add(create_complex_btn);
            Controls.Add(create_real_btn);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "InitialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pick an option";
            ResumeLayout(false);
        }

        #endregion

        private Button create_real_btn;
        private Button create_complex_btn;
        private Button create_list_btn;
        private Button create_matrix_btn;
        private Button create_obj_list_btn;
        private Button show_faq_btn;
    }
}