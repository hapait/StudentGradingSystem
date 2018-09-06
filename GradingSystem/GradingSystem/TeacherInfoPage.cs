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
    public partial class TeacherInfoPage : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public TeacherInfoPage()
        {
            InitializeComponent();
        }

        public Form RefToForm1
        {
            get;
            set;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CourseInfoPage().Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            teacherIdTextBox.Text = index.ToString();
            string sid = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string nm = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string ds = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string uname = dataGridView1.Rows[index].Cells[3].Value.ToString();
            teacherIdTextBox.Text = sid;
            nameTextBox.Text = nm;
            designationTextBox.Text = ds;
            usernameTextBox.Text = uname;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || designationTextBox.Text == "" || usernameTextBox.Text == "" )
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = teacherIdTextBox.Text,
                       n = nameTextBox.Text,
                       d = designationTextBox.Text,
                       u = usernameTextBox.Text,
                       p = nameTextBox.Text + teacherIdTextBox.Text;


                connection.Open();
                command.Connection = connection;
                String sql = "";
                sql = "insert into TeacherInfo(TeacherId, Name, Designation, Username, Password) VALUES ('" + i + "','" + n + "','" + d + "','" + u + "','" + p + "')";
                command.CommandText = sql;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (teacherIdTextBox.Text == "" || nameTextBox.Text == "" || designationTextBox.Text == "" || usernameTextBox.Text == "")
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = teacherIdTextBox.Text,
                       n = nameTextBox.Text,
                       d = designationTextBox.Text,
                       u = nameTextBox.Text,
                       p = teacherIdTextBox.Text + nameTextBox.Text;

                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                    SqlCommand comm = new SqlCommand("Delete From [TeacherInfo]  Where TeacherId=@tid", conn);
                    comm.Parameters.AddWithValue("@tid", i);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();

                    connection.Open();
                    command.Connection = connection;
                    String sql = "";
                    sql = "insert into TeacherInfo(TeacherId, Name, Designation, Username, Password) VALUES ('" + i + "','" + n + "','" + d + "','" + u + "','" + p + "')";
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

            if (teacherIdTextBox.Text == "" || nameTextBox.Text == "" || designationTextBox.Text == "" || usernameTextBox.Text == "")
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = teacherIdTextBox.Text,
                       n = nameTextBox.Text,
                       d = designationTextBox.Text,
                       u = nameTextBox.Text,
                       p = teacherIdTextBox.Text + nameTextBox.Text;

                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                    SqlCommand comm = new SqlCommand("Delete From [TeacherInfo]  Where TeacherId=@tid", conn);
                    comm.Parameters.AddWithValue("@tid", i);
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

        private void TeacherInfoPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradingSystemDataSet.TeacherInfo' table. You can move, or remove it, as needed.
            this.teacherInfoTableAdapter.Fill(this.gradingSystemDataSet.TeacherInfo);

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeacherInfoPage().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teacherIdTextBox.Text = "";
            nameTextBox.Text = "";
            designationTextBox.Text = "";
            usernameTextBox.Text = "";
        }

        private void studentInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InformationPage().Show();
        }
    }
}
