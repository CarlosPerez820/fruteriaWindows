namespace Sistema_Fruteria
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Principal frm_principal = new Principal();
            frm_principal.Show(); 
            //this.Hide();
        }
    }
}
