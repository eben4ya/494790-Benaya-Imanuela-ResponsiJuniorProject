using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ResponsiJunpro
{
    public partial class Form1 : Form
    {
        private DatabaseHandler dbHandler;
        private string connString = "Host=localhost;Port=5432;Username=postgres;Password=eben1276@;Database=ResponsiJunpro";
        public DataTable dt;
        private DataGridViewRow row;
        public DataGridViewRow Row { get => row; set => row = value; }
        public Form1()
        {
            InitializeComponent();
            dbHandler = new DatabaseHandler(connString);
            LoadData();
        }

        //get department id
        private int GetDepartmentId()
        {
            if(rbHR.Checked) return 1;
            if(rbENG.Checked) return 2;
            if (rbDEV.Checked) return 3;
            if (rbPM.Checked) return 4;
            if (rbFin.Checked) return 5;
            return 0;
        }

        private void HandleStatusCode(int statusCode, string successMessage, string errorMessage)
        {
            if(statusCode == 200 || statusCode == 201 || statusCode == 204)
            {
                MessageBox.Show($"[{statusCode}] {successMessage}", "Success");
                LoadData();
            }
            else if (statusCode == 409 || statusCode == 404)
            {
                throw new Exception($"[{statusCode}] {errorMessage}");
            }
        }

        //add employee function
        private void InsertData()
        {
            string nama = tbName.Text;
            int id_dep = GetDepartmentId();

            if(id_dep == 0) 
            {
                MessageBox.Show("Pilih Departemen!");
                return;
            }

            string sql = "SELECT * FROM add_employee(@in_id_karyawan, @in_nama, @in_id_dep)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@in_id_karyawan", id_dep.ToString()),
                new NpgsqlParameter("@in_nama", nama),
                new NpgsqlParameter("@in_id_dep", id_dep)
            };

            try
            {
                int statusCode = dbHandler.ExecuteNonQuery(sql, parameters);
                HandleStatusCode(statusCode, "Berhasil dibuat!", "Karyawan sudah ada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //edit employee function
        private void EditData()
        {
            if(Row == null)
            {
                MessageBox.Show("Pilih karyawan untuk di edit", "Info");
                return;
            }
            string nama = tbName.Text;
            int id_dep = GetDepartmentId();

            if (id_dep == 0)
            {
                MessageBox.Show("Pilih Departemen!");
                return;
            }

            string sql = "SELECT * FROM edit_employee(@in_id_karyawan, @in_nama, @in_id_dep)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@in_id_karyawan", Row.Cells["id_karyawan"].Value),
                new NpgsqlParameter("@in_nama", nama),
                new NpgsqlParameter("@in_id_dep", id_dep)
            };

            try
            {
                int statusCode = dbHandler.ExecuteNonQuery(sql, parameters);
                HandleStatusCode(statusCode, "Edit Berhasil!", "Karyawan tidak ditemukan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //edit employee function
        private void DeleteData()
        {
            if (Row == null)
            {
                MessageBox.Show("Pilih karyawan untuk di edit", "Info");
                return;
            }

            string sql = "SELECT * FROM delete_employee(@in_id_karyawan)";
            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@in_id_karyawan", Row.Cells["id_karyawan"].Value),
            };

            try
            {
                int statusCode = dbHandler.ExecuteNonQuery(sql, parameters);
                HandleStatusCode(statusCode, "Hapus Karyawan Berhasil!", "Karyawan tidak ditemukan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //edit employee function
        private void LoadData()
        {
            string sql = "SELECT * FROM karyawan, departemen WHERE karyawan.id_dep = departemen.id_dep ";
   

            try
            {
               dbHandler.ExecuteSelectQuery(sql, null);
                dgvDataTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }





        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            InsertData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }

    public class DatabaseHandler
    {
        private string connString;
        private NpgsqlConnection conn;

        //encapsulation
        public DatabaseHandler(string connString) 
        { 
            this.connString = connString;
        }

        //Open DB Connection
        public void OpenConnection()
        {
            conn = new NpgsqlConnection(connString);
            conn.Open();
            MessageBox.Show("Connected to DB!", "Notification");
        }

        //Close DB Connection
        public void CloseConnection() 
        { 
            if (conn != null)
            {
                conn.Close();
            }
        }

        // Execute SELECT QUERY
        public DataTable ExecuteSelectQuery(string sql, NpgsqlParameter[] parameters)
        {
            try
            {
                OpenConnection();
                var cmd = new NpgsqlCommand(sql, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally 
            { 
                CloseConnection();
            }
        }

        // Execute INSERT, UPDATE, DELETE QUERY
        public DataTable ExecuteNonQuery(string sql, NpgsqlParameter[] parameters)
        {
            try
            {
                OpenConnection();
                var cmd = new NpgsqlCommand(sql, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
