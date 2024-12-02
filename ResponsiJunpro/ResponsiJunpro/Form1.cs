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
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
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

                return (DataTable)cmd.ExecuteScalar();
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
