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

        private void btndaftar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login Login = new login();
            Login.Show();
            this.Hide();
        }
    }
}
