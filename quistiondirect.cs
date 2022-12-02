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

namespace EXAMEN

{

    public partial class quistiondirect : Form
    {
        SqlConnection chaine = new SqlConnection(@"Data Source=DESKTOP-7MJDDPC\MSSQLSERVER03;Initial Catalog=Examen;Integrated Security=True");

        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public quistiondirect()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            chaine.Open();
            SqlCommand cmd = new SqlCommand("insert into questiondirect values" + "('" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "')", chaine);

             cmd.ExecuteNonQuery();
            MessageBox.Show("bien Ajouter ");
            chaine.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chaine.Open();
            cmd.Connection = chaine;
            cmd.CommandText = ("select * from questiondirect");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            chaine.Close();
        }
    }
}
