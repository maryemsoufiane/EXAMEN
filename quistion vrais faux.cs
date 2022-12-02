using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXAMEN
{
    
    public partial class quistion_vrais_faux : Form
    {
        SqlConnection chaine = new SqlConnection(@"Data Source=DESKTOP-7MJDDPC\MSSQLSERVER03;Initial Catalog=Examen;Integrated Security=True");

        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public quistion_vrais_faux()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            chaine.Open();
            SqlCommand cmd = new SqlCommand("insert into vraisfaux values" + "('" + textBox2.Text + "','" + textBox1.Text  + "')", chaine);

            cmd.ExecuteNonQuery();
            MessageBox.Show("bien Ajouter ");
            chaine.Close();


        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if(checkBox1.Checked)
            {
               /* chaine.Open();
                SqlCommand cmd = new SqlCommand("insert into questiondirect values( true)" + "('" +  checkBox1.Text + "')", chaine);

                cmd.ExecuteNonQuery();
                MessageBox.Show("bien Ajouter ");
                chaine.Close();¨*/
            }
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox2.Checked)
            {
                /*chaine.Open();
                SqlCommand cmd = new SqlCommand("insert into vraisfaux values( false)" + "('" + checkBox2.Text + "')", chaine);

                cmd.ExecuteNonQuery();
                MessageBox.Show("bien Ajouter ");
                chaine.Close()¨*/
            }
    }

        private void button2_Click(object sender, System.EventArgs e)
        {
            chaine.Open();
            cmd.Connection = chaine;
            cmd.CommandText = ("select * from qcm");
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            chaine.Close();
        }
    }
}
