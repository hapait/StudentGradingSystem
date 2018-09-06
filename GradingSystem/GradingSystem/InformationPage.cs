using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GradingSystem
{
    public partial class InformationPage : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public InformationPage()
        {
            InitializeComponent();
            searchComboBox.SelectedIndex = 1;
        }

        public Form RefToForm1 
        {
            get;
            set;
        }

        private void InformationPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.RefToForm1.Show();
        }

        private void InformationPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradingSystemDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.gradingSystemDataSet.StudentInfo);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            studentIdTextBox.Text = index.ToString();
            string sid = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string nm = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string rl = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string yr = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string sess = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string uname = dataGridView1.Rows[index].Cells[5].Value.ToString();
            studentIdTextBox.Text = sid;
            nameTextBox.Text = nm;
            rollTextBox.Text = rl;
            yearTextBox.Text = yr;
            sessionTextBox.Text = sess;
            usernameTextBox.Text = uname;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "" || rollTextBox.Text == "" || yearTextBox.Text == "" || sessionTextBox.Text == "")
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = studentIdTextBox.Text,
                       n = nameTextBox.Text,
                       r = rollTextBox.Text,
                       y = yearTextBox.Text,
                       s = sessionTextBox.Text,
                       u = nameTextBox.Text,
                       p = rollTextBox.Text;
                       

                connection.Open();
                command.Connection = connection;
                String sql = "";
                sql = "insert into StudentInfo(StudentId, Name, Roll, Year, Session, Username, Password) VALUES ('" + i + "','" + n + "','" + r + "','" + y + "','" + s + "','" + u + "','" + p + "')";
                command.CommandText = sql;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || rollTextBox.Text == "" || yearTextBox.Text == "" || sessionTextBox.Text == "")
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = studentIdTextBox.Text,
                       n = nameTextBox.Text,
                       r = rollTextBox.Text,
                       y = yearTextBox.Text,
                       s = sessionTextBox.Text,
                       u = nameTextBox.Text,
                       p = rollTextBox.Text;

                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                    SqlCommand comm = new SqlCommand("Delete From [StudentInfo]  Where StudentId=@stdid", conn);
                    comm.Parameters.AddWithValue("@stdid", i);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();

                    connection.Open();
                    command.Connection = connection;
                    String sql = "";
                    sql = "insert into StudentInfo(StudentId, Name, Roll, Year, Session, Username, Password) VALUES ('" + i + "','" + n + "','" + r + "','" + y + "','" + s + "','" + u + "','" + p + "')";
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (SystemException ex)
                {
                    //MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }
            }     
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (studentIdTextBox.Text == ""|| nameTextBox.Text == "" || rollTextBox.Text == "" || yearTextBox.Text == "" || sessionTextBox.Text == "")
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = studentIdTextBox.Text,
                       n = nameTextBox.Text,
                       r = rollTextBox.Text,
                       y = yearTextBox.Text,
                       s = sessionTextBox.Text,
                       u = nameTextBox.Text,
                       p = rollTextBox.Text;

                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                    SqlCommand comm = new SqlCommand("Delete From [StudentInfo]  Where StudentId=@stdid", conn);
                    comm.Parameters.AddWithValue("@stdid", i);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
                catch (SystemException ex)
                {
                    //MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            studentIdTextBox.Text = "";
            nameTextBox.Text = "";
            rollTextBox.Text = "";
            yearTextBox.Text = "";
            sessionTextBox.Text = "";
            usernameTextBox.Text = "";
        }

        private void refreshTable()
        {
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InformationPage().Show();
        }

        private void teacherInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeacherInfoPage().Show();
        }

        private void courseInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CourseInfoPage().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = searchTextBox.Text;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "select * from StudentInfo where ";
        }

        private void searchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            string columnName = searchComboBox.SelectedItem.ToString();
            /*
            if (searchComboBox.SelectedItem == "StudentId")
            {
                que = "select * from StudentInfo where StudentId = '" + s + "'";
            }
            else if (searchComboBox.SelectedItem == "Name")
            {
                que = "select * from StudentInfo where Name = '" + s + "'";
            }
            else if (searchComboBox.SelectedItem == "Roll")
            {
                que = "select * from StudentInfo where Roll = '" + s + "'";
            }
            else if (searchComboBox.SelectedItem == "Year")
            {
                que = "select * from StudentInfo where Year = '" + s + "'";
            }
            else if (searchComboBox.SelectedItem == "Session")
            {
                que = "select * from StudentInfo where Session = '" + s + "'";
            }
            else if (searchComboBox.SelectedItem == "Username")
            {
                que = "select * from StudentInfo where Username = '" + s + "'";
            }
            else
            {
                que = "";
            }*/

            connection.Open();
            command.Connection = connection;
            //command.CommandText = "select * from StudentInfo where Username = '" +  + "' = '" + s + "'";
            dataReader = command.ExecuteReader();
            dataReader.Read();

            //dataGridView1.DataBindings = dataReader;
            

        }
    }
}
