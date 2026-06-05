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

namespace Projeto_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarTela()
        {
            SqlCommand comando = new SqlCommand("select* From CadastroUsuarios", connection);
            SqlDataAdapter sd = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarTela();
        }
        private SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Usuarios;Data Source=SARAH\\SQLEXPRESS");

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("insert into CadastroUsuarios(Nome,Email,Telefone,Estado,Cidade) values(@Nome,@Email,@Estado,@Cidade,@Telefone)", connection);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = txtEstado.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txtCidade.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = maskTelefone.Text;


            try
            {

                connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário adicionado com sucesso!");
                MostrarTela();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select* from CadastroUsuarios where ID=@ID", connection);
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = txtBuscar.Text;
            SqlDataAdapter sd = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
