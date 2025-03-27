using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DisconnectedMode
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable instructorDT;
        private int nextId = 0;
        private int selectedID;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Server = DESKTOP-PFCJAQ5\\SQLEXPRESS;Database = ITI; Trusted_Connection = True;TrustServerCertificate = True");
            adapter = new SqlDataAdapter();
        }

        private void btn_GetData_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Instructor", connection);
            adapter.SelectCommand = command;
            instructorDT = new DataTable();
            adapter.Fill(instructorDT);
            nextId = (int)instructorDT.Rows[instructorDT.Rows.Count - 1]["Ins_Id"] + 1;
            dgv_Instructors.DataSource = instructorDT;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand DepartmentCommand = new SqlCommand("select Dept_Id,Dept_Name from Department", connection);
            adapter.SelectCommand = DepartmentCommand;
            DataTable dat = new DataTable();
            adapter.Fill(dat);
            InputDepartment.DataSource = dat;
            InputDepartment.DisplayMember = "Dept_Name";
            InputDepartment.ValueMember = "Dept_Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow newRow = instructorDT.NewRow();
            newRow["Ins_Id"] = nextId++;
            newRow["Ins_Name"] = InputName.Text;
            newRow["Ins_Degree"] = InputDegree.Text;
            newRow["Salary"] = InputSalary.Value;
            newRow["Dept_Id"] = InputDepartment.SelectedValue;
            instructorDT.Rows.Add(newRow);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Instructors.Rows)
            {
                int nRow = Convert.ToInt32(row.Cells[0].Value);
                if (nRow == selectedID)
                {
                    row.Cells[1].Value = InputName.Text;
                    row.Cells[2].Value = InputDegree.Text;
                    row.Cells[3].Value = InputSalary.Value;
                    row.Cells[4].Value = InputDepartment.SelectedValue;
                }
            }
        }

        private void btn_UpdateDatabase_Click(object sender, EventArgs e)
        {
            SqlCommand insert = new SqlCommand("insert into Instructor(Ins_Id,Ins_Name,Ins_Degree,Salary,Dept_Id)\r\nvalues(@id,@name,@degree,@salary,@dept_ID)", connection);
            insert.Parameters.Add("id", SqlDbType.Int, 4, "Ins_Id");
            insert.Parameters.Add("name", SqlDbType.NVarChar, 50, "Ins_Name");
            insert.Parameters.Add("degree", SqlDbType.NVarChar, 50, "Ins_Degree");
            insert.Parameters.Add("salary", SqlDbType.Money, 8, "Salary");
            insert.Parameters.Add("dept_ID", SqlDbType.Int, 4, "Dept_Id");

            SqlCommand update = new SqlCommand("update Instructor set Salary=@salary,Dept_Id=@dept_ID,Ins_Degree=@degree where Ins_Id=@id", connection);
            update.Parameters.Add("id", SqlDbType.Int, 4, "Ins_Id");

            update.Parameters.Add("degree", SqlDbType.NVarChar, 50, "Ins_Degree");
            update.Parameters.Add("salary", SqlDbType.Money, 8, "Salary");
            update.Parameters.Add("dept_ID", SqlDbType.Int, 4, "Dept_Id");

            SqlCommand delete = new SqlCommand("delete from Instructor where Ins_Id=@id", connection);
            delete.Parameters.Add("id", SqlDbType.Int, 4, "Ins_Id");

            adapter.InsertCommand = insert;
            adapter.UpdateCommand = update;
            adapter.DeleteCommand = delete;

            adapter.Update(instructorDT);
            btn_GetData_Click(null, null);
        }

        private void dgv_Instructors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgv_Instructors.SelectedRows[0];

            InputName.Text = dataGridViewRow.Cells[1].Value.ToString();
            InputDegree.Text = dataGridViewRow.Cells[2].Value.ToString();
            InputSalary.Value = (decimal)dataGridViewRow.Cells[3].Value;
            InputDepartment.SelectedValue = (int)dataGridViewRow.Cells[4].Value;
            selectedID = (int)dataGridViewRow.Cells[0].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Instructors.Rows)
            {
                int nRow = Convert.ToInt32(row.Cells[0].Value);
                if (nRow == selectedID)
                {
                    dgv_Instructors.Rows.Remove(row);
                }
            }
        }
    }
}