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
    }
}