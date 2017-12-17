using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Posts_
{
    public partial class ComponenteAnotacao : UserControl
    {
        public int codigo_post = 0;

        public ComponenteAnotacao()
        {
            InitializeComponent();
        }


        public void setCodigo(int codigo)
        {
            codigo_post = codigo;
        }

        public void setConteudo(string conteudo)
        {
            txt_conteudo.Text = conteudo;
        }

        public void setDataHora(string datahora)
        {
            txt_data_hora.Text = datahora;
        }

        public void setImage(Image imagem)
        {
            foto_perfil.Image = imagem;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComponentePost_Load(object sender, EventArgs e)
        {

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Você vai mesmo excluir essa anotação?", "Hey, atenção!", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=projeto_diario;uid=root;pwd=;");

                conexao.Open();

                MySqlCommand cmd = conexao.CreateCommand();

                cmd.CommandText = "DELETE FROM ANOTACOES WHERE COD = ?codigo";

                cmd.Parameters.AddWithValue("?codigo", codigo_post);

                cmd.ExecuteNonQuery();

                conexao.Close();

                ((FlowLayoutPanel)this.Parent).BackColor = Color.Gainsboro;

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }
    }
}
