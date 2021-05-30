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
    public partial class BuildingFRM : Form
    {
        public BuildingFRM()
        {
            InitializeComponent();
        }
        public string conniction = "Data Source = DESKTOP-L3S7CS9\\SQLEXPRESS ; initial catalog = CarsBuilding ; integrated security=true";
        private void BuildingFRM_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            int fn;
            int.TryParse(FNTXT.Text, out fn);
            insertB(BNTXT.Text, fn, PNTXT.Text, RONCMB.Text);
            MessageBox.Show("saved");
        }

        private void insertB (string bn , int floor , string P, string ron)
        {
            SqlConnection sqlcon = new SqlConnection(conniction);

            SqlCommand cmd = new SqlCommand("insertProB", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BN", SqlDbType.VarChar, 50).Value = bn;
            cmd.Parameters.Add("@FN", SqlDbType.Int).Value = floor;
            cmd.Parameters.Add("@PN", SqlDbType.VarChar, 50).Value = P;
            cmd.Parameters.Add("@PRON", SqlDbType.VarChar, 50).Value = ron;
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("connected");
            sqlcon.Close();
        }

        
        private void ViewBBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewBFRM vf = new viewBFRM();
            vf.Show();
            
        }


    }
}
