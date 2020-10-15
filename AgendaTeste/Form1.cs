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

namespace AgendaTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarContato_Click(object sender, EventArgs e)
        {
            string nome = txtContatoNovo.Text;

            string strConn = @"Data Source=.\sqlExpress;Initial Catalog=Agenda;Integrated Security=True;";
            SqlConnection con = new SqlConnection(strConn);
            Guid guid = Guid.NewGuid();

            con.Open();
            
            string sql = String.Format("INSERT INTO Contato(Id, Nome) VALUES ('{0}', '{1}')", guid, nome);
            SqlCommand com = new SqlCommand(sql, con);
            com.ExecuteNonQuery();
            
            sql = String.Format("SELECT Nome FROM Contato WHERE Id = '{0}'", guid);
            com = new SqlCommand(sql, con);
            txtContatoSalvo.Text = com.ExecuteScalar().ToString();
            
            con.Close();
        }
    }
}
