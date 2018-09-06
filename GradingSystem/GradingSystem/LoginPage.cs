using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            typeComboBox.SelectedIndex = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem == "Admin")
            {
                AdminLogin();
            }
            else if (typeComboBox.SelectedItem == "Teacher")
            {
                TeacherLogin();
            }
            else if (typeComboBox.SelectedItem == "Student")
            {
                StudentLogin();
            }
            
        }

        private void TeacherLogin()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                SqlDataReader dataReader;

                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;


                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from TeacherInfo where Username = '" + username + "'and Password = '" + password + "'";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    InformationPage obj2 = new InformationPage();
                    obj2.RefToForm1 = this;
                    this.Visible = false;
                    obj2.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void StudentLogin()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                SqlDataReader dataReader;

                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;


                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from StudentInfo where Username = '" + username + "'and Password = '" + password + "'";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    InformationPage obj2 = new InformationPage();
                    obj2.RefToForm1 = this;
                    this.Visible = false;
                    obj2.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void AdminLogin()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                SqlDataReader dataReader;

                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                

                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from AdminInfo where Username = '" + username + "'and Password = '" + password + "'";
                dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows)
                {
                    InformationPage obj2 = new InformationPage();
                    obj2.RefToForm1 = this;
                    this.Visible = false;
                    obj2.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
