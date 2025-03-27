using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Ado.NetTraining
{
    public partial class CourseCRUD : Form
    {
        private SqlConnection connection;
        private int CourseId;

        public CourseCRUD()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=DESKTOP-PFCJAQ5\\SQLEXPRESS;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void CourseCRUD_Load(object sender, EventArgs e)
        {
            GetCourses();
            GetTopics();
            btn_update.Visible = false;
            btn_delete.Visible = false;
        }

        private void GetCourses()
        {
            //Select * from Course
            SqlCommand command = new SqlCommand("select c.Crs_Id,c.Crs_Name,c.Crs_Duration,t.Top_Name from course c,Topic t where t.Top_Id = c.Top_Id", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            connection.Close();
            dgv_courses.DataSource = dataTable;
        }

        private void GetTopics()
        {
            SqlCommand command = new SqlCommand("select Top_Id,Top_Name from Topic", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            connection.Close();
            TopicInput.DataSource = dataTable;
            TopicInput.DisplayMember = "Top_Name";
            TopicInput.ValueMember = "Top_Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"insert into Course values ({IdInput.Value}, '{NameInput.Text}', {DurationInput.Value}, {TopicInput.SelectedValue})", connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course added successfully");
                    GetCourses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;

            DataGridViewRow row = dgv_courses.Rows[e.RowIndex];
            IdInput.Value = (int)row.Cells[0].Value;
            NameInput.Text = row.Cells[1].Value.ToString();
            DurationInput.Value = (int)row.Cells[2].Value;
            TopicInput.SelectedValue = (int)row.Cells[3].Value;

            CourseId = (int)row.Cells[0].Value;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand($"update Course set Crs_Id = {IdInput.Value},Crs_Name='{NameInput.Text}',Crs_Duration={DurationInput.Value},Top_Id={TopicInput.SelectedValue} where Crs_Id = {CourseId}", connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course Updated successfully");
                    GetCourses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            IdInput.Value = 1;
            NameInput.Text = "";
            DurationInput.Value = 1;
            TopicInput.Text = "";
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"delete from Course where Crs_Id = {CourseId};", connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Course Deleted successfully");
                GetCourses();
            }
            else
            {
                MessageBox.Show("Course not found");
            }

            IdInput.Value = 1;
            NameInput.Text = "";
            DurationInput.Value = 1;
            TopicInput.Text = "";
            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
        }
    }
}