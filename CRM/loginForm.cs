using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM
{
    public partial class loginForm : Form
    {
        private Database database = new Database();
        private Translation translation = new Translation();
        public  Boolean checkIfLoginValid(string username, string password)
        {
            DataTable loginQueryResult = database.GetQueryResultAsDatatable("SELECT COUNT(*) FROM user WHERE username='" + username + "' AND password='" + password + "'");
            if (loginQueryResult.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public loginForm()
        {
            InitializeComponent();
        }
        private User User = new User();
        public User GetUser()
        {
            return this.User;
        }
        private void loginForm_Load(object sender, EventArgs e)
        {
            loginTitleLabel.Text = this.translation.GetLoginTranslation();
            userNameLabel.Text = this.translation.GetUserLabelTranslation();
            passwordLabel.Text = this.translation.GetPasswordLabelTranslation();
            loginButton.Text = this.translation.GetLoginTranslation();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (checkIfLoginValid(usernameTextbox.Text, passwordTextbox.Text))
            {
                this.User.Username = usernameTextbox.Text;
                this.User.UserId = Convert.ToInt32(database.GetQueryResultAsString("SELECT userid FROM user WHERE userName ='" + this.User.Username + "'  "));
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show(this.translation.GetIncorrectLogin());
            }
        }
    }
}
