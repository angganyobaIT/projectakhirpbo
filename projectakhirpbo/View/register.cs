namespace projectakhirpbo
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            //Console.WriteLine("HELLO WORLD")
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
