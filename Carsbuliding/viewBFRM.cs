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

namespace Carsbuliding
{
    public partial class viewBFRM : Form
    {
        public viewBFRM()
        {
            InitializeComponent();
        }
        public string conniction = "Data Source = DESKTOP-O9932VP\\SQLEXPRESS ; initial catalog = CarsBuilding ; integrated security=true";
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            chooseTXT.Text = dataGridView1.CurrentCell.Value.ToString();
        }
        private void viewB()
        {
            SqlConnection sqlcon = new SqlConnection(conniction);
            SqlCommand cmd = new SqlCommand("viewProB", sqlcon);
            SqlDataAdapter sqlaa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlaa.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void viewBFRM_Load(object sender, EventArgs e)
        {
            viewB();
        }

        private void chooseTXT_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            
            deleteB(chooseTXT.Text);
            viewB();
        }

        private void deleteB(string BN)
        {
            SqlConnection sqlcon = new SqlConnection(conniction);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("deleteProB", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Bname", SqlDbType.VarChar,50).Value = BN;
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("deleted");
            
        }
    }
}
