using LoginForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string path = @"../../../TextList.txt";


            const string UserFilePath = @"C:\PPGit\LoginForm\LoginForm\TextList.txt";

            string UserName=txtUserName.Text;
            string Password = txtParol.Text;
            
            if(string.IsNullOrWhiteSpace(UserName) && string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Ma'lumotlarni to'liq kiriting.");
            }


            List<Users> users = new List<Users>();

            if (File.Exists(path))
            {
                var usersfile = File.ReadAllText(path);
                users = new List<Users>();
            }



            List<string> userSting = new List<string>();

          
            
            userSting=File.ReadAllLines(UserFilePath).ToList();

            users=FunctionClass.ReadAllLine(userSting);

         
         
            Login lgn = new Login();
            this.Hide();
               
             //string SADirectory = @"C:\PPGit\LoginForm\SuperAdmin\TextSA.txt";
            //Directory.CreateDirectory(SADirectory);
            //FileInfo fileInfo = new FileInfo(SADirectory);
            //string Name=fileInfo.Name;
            //FileStream fileStream = fileInfo.Create();
            //fileInfo.IsReadOnly = false;
            //fileStream.Close();
    
             SuperAdmin form3 = new SuperAdmin();
             form3.Show();
                

            
          
            }
            
        }
    
    }

