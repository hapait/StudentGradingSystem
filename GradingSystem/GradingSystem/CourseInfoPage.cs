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
    public partial class CourseInfoPage : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;

        public CourseInfoPage()
        {
            InitializeComponent();
        }

        private void CourseInfoPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gradingSystemDataSet3.CourseInfo' table. You can move, or remove it, as needed.
            this.courseInfoTableAdapter.Fill(this.gradingSystemDataSet3.CourseInfo);

        }

        private void insertButton_Click(object sender, EventArgs e)
        {

            if (titleTextBox.Text == "" || teacherTextBox.Text == "" || creditTextBox.Text == "")
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = courseIdTextBox.Text,
                       t = titleTextBox.Text,
                       tr = teacherTextBox.Text,
                       cr = creditTextBox.Text;


                connection.Open();
                command.Connection = connection;
                String sql = "";
                sql = "insert into CourseInfo(CourseId, Title, Teacher, Credit) VALUES ('" + i + "','" + t + "','" + tr + "','" + cr + "')";
                command.CommandText = sql;
                command.ExecuteNonQuery();
                connection.Close();
            }
        
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (courseIdTextBox.Text == "" || titleTextBox.Text == "" || teacherTextBox.Text == "" || creditTextBox.Text == "")
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = courseIdTextBox.Text,
                       t = titleTextBox.Text,
                       tr = teacherTextBox.Text,
                       cr = creditTextBox.Text;

                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                    SqlCommand comm = new SqlCommand("Delete From [CourseInfo]  Where CourseId=@cid", conn);
                    comm.Parameters.AddWithValue("@cid", i);
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();

                    connection.Open();
                    command.Connection = connection;
                    String sql = "";
                    sql = "insert into CourseInfo(CourseId, Title, Teacher, Credit) VALUES ('" + i + "','" + t + "','" + tr + "','" + cr + "')";
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

        private void deleteButt_Click(object sender, EventArgs e)
        {
            if (courseIdTextBox.Text == "" || titleTextBox.Text == "" || teacherTextBox.Text == "" || creditTextBox.Text == "")
            {
                MessageBox.Show("You can't leave any field empty!");
            }
            else
            {
                string i = courseIdTextBox.Text,
                       t = titleTextBox.Text,
                       tr = teacherTextBox.Text,
                       cr = creditTextBox.Text;

                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=Hapait;Initial Catalog=GradingSystem;Integrated Security=True");
                    SqlCommand comm = new SqlCommand("Delete From [CourseInfo]  Where CourseId=@cid", conn);
                    comm.Parameters.AddWithValue("@cid", i);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            courseIdTextBox.Text = index.ToString();
            string cid = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string tl = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string tr = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string cr = dataGridView1.Rows[index].Cells[3].Value.ToString();
            courseIdTextBox.Text = cid;
            titleTextBox.Text = tl;
            teacherTextBox.Text = tr;
            creditTextBox.Text = cr;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            courseIdTextBox.Text = "";
            titleTextBox.Text = "";
            teacherTextBox.Text = "";
            creditTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CourseInfoPage().Show();
        }

        private void studentInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InformationPage().Show();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeacherInfoPage().Show();
        }

        private void CourseInfoPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
