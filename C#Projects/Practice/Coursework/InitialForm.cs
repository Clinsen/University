namespace Coursework
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void create_real_btn_Click(object sender, EventArgs e)
        {
            RealForm form = new RealForm();
            form.Show();
        }

        private void create_complex_btn_Click(object sender, EventArgs e)
        {
            ComplexForm form = new ComplexForm();
            form.Show();
        }

        private void create_list_btn_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm();
            form.Show();
        }

        private void create_matrix_btn_Click(object sender, EventArgs e)
        {
            MatrixForm form = new MatrixForm();
            form.Show();
        }

        private void show_faq_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Kyshynskyi Oleksandr (CSA-11)", "FAQ"); // Computer Science Abbrevated - Комп'ютерні Науки Скорочено (термін навчання)
        }

        private void create_obj_list_btn_Click(object sender, EventArgs e)
        {
            ObjectListForm form = new ObjectListForm();
            form.Show();
        }
    }
}