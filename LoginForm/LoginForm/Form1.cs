using LoginForm.Models;

namespace LoginForm
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string UserFilePath = @"C:\PPGit\LoginForm\LoginForm\TextList.txt";
            string[] id=File.ReadAllLines(UserFilePath);
            File.AppendAllText(UserFilePath,
                id.Length.ToString() 
                     + "," + FulName.Text
                     +"," + lbUserName.Text
                     +"," + lbPassword.Text
                     +"," + RoleList.User
                     + "\n" 
                );
          
          
            if (FulName.Text== "" || lbUserName.Text == "" || lbPassword.Text == "")
            {
                MessageBox.Show("Xatolik bor !");
            }
            else
            {
                Form1 form1 = new Form1();
                this.Hide();
            
                Login login = new Login();
                login.Show();
            }
        }
        private void FulName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
