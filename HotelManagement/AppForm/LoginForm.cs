using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelManagement.Data;

namespace HotelManagement.AppForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressDialog progress = new ProgressDialog();
                progress.Show();

                DataBase db = new DataBase();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                db.openConnection();
                SqlCommand cm = new SqlCommand(
                    "SELECT Account.Username , Employee_Position.position, Account.userId " +
                    "FROM Account inner join Employee_Position on Account.userId = Employee_Position.Id " +
                    "WHERE UserName = @User AND Password = @Pass", db.Connection);
                cm.Parameters.Add("@User", SqlDbType.VarChar).Value = Username_textBox.Text;
                cm.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Password_textBox.Text;
                adapter.SelectCommand = cm;

                progress.Bar.Value = 50;

                adapter.Fill(table);

                progress.Bar.Value = 100;

                db.closeConnection();

                progress.Close();

                if (table.Rows.Count > 0)
                {
                    User.UserName = table.Rows[0][0].ToString();
                    User.Id = Convert.ToInt32(table.Rows[0][1]);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        User.Roles.Add(Convert.ToInt32(table.Rows[i][2]));
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Username");
                throw;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Username_textBox.Text.Length != 0)
                {
                    errorProvider1.SetError(Username_textBox, null);
                }
                else
                {
                    errorProvider1.SetError(Username_textBox, "Please enter username!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Password_textBox.Text.Length != 0)
                {
                    errorProvider2.SetError(Password_textBox, null);
                }
                else
                {
                    errorProvider2.SetError(Password_textBox, "Please enter password!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
