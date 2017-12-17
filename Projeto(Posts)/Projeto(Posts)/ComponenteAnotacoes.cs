using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Collections.Generic;
using System.Web;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Projeto_Posts_
{
    public partial class ComponenteAnotacoes : UserControl
    {

        int num_anotacoes = 1;

        public ComponenteAnotacoes()
        {

            InitializeComponent();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=projeto_diario;uid=root;pwd=;");
            
            conexao.Open();
            
            MySqlCommand comando = conexao.CreateCommand();
            
            comando.CommandText = "INSERT INTO ANOTACOES(CONTEUDO) VALUES (?conteudo)";
            
            comando.Parameters.AddWithValue("?conteudo", txt_anotacoes.Text);
            
            comando.ExecuteNonQuery();
            
            conexao.Close();

            txt_anotacoes.Clear();

            carregaAnotacoes();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComponenteAnotacoes_Load(object sender, EventArgs e)
        {
            //receberAnotacoesServidor();
            //var url = "hhttp://webserverlab.000webhostapp.com/api/anotacao/ler.php";
            //var anotacoes = _download_serialized_json_data<Anotacao>(url);
            //MessageBox.Show("" + anotacoes);
            receberAnotacoes();
            carregaAnotacoes();
        }


        public async void enviarAnotacaoServidor()
        {
            string conteudo = txt_anotacoes.Text;

            string anotacao = "{'Conteudo':'{anotacao}'}";

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    "http://yourUrl",
                     new StringContent(anotacao, Encoding.UTF8, "application/json"));
            }

        }

        public async void receberAnotacoesServidor()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                // HTTP POST
                client.BaseAddress = new Uri("http://webserverlab.000webhostapp.com");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("/api/anotacao/ler.php").Result;
                string res = "";
                using (HttpContent content = response.Content)
                {
                    // ... Read the string.
                    Task<string> result = content.ReadAsStringAsync();
                    res = result.Result;
                    MessageBox.Show(res);
                }
            }
        }

        public async void  receberAnotacoes()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

                var response = httpClient.GetStringAsync(new Uri("http://webserverlab.000webhostapp.com/api/anotacao/ler.php")).Result;

                var releases = JArray.Parse(response);

                foreach (var anotacao in releases)
                {
                    MessageBox.Show(releases.ToString());
                }

                
            }
        }

        private static Anotacao _download_serialized_json_data<Anotacao>(string url) where Anotacao : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<Anotacao>(json_data) : new Anotacao();
            }
        }

        public void carregaAnotacoes()
        {

            painel_anotacoes.Controls.Clear();
               
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=projeto_diario;uid=root;pwd=;");

            conexao.Open();

            MySqlCommand cmd = conexao.CreateCommand();

            cmd.CommandText = "SELECT * FROM anotacoes ORDER BY horario DESC";

            MySqlDataReader resultado_consulta = cmd.ExecuteReader();

            while (resultado_consulta.Read())
            {

                ComponenteAnotacao nova_anotacao = new ComponenteAnotacao();

                nova_anotacao.Top = painel_anotacoes.Top + 75 * num_anotacoes;

                nova_anotacao.Left = painel_anotacoes.Left;

                nova_anotacao.setCodigo(resultado_consulta.GetInt32("COD"));

                nova_anotacao.setConteudo(resultado_consulta.GetString("CONTEUDO"));

                nova_anotacao.setDataHora(resultado_consulta.GetString("HORARIO"));

                painel_anotacoes.Controls.Add(nova_anotacao);

                num_anotacoes++;

            }

            conexao.Close();
                
        }

        private void painel_anotacoes_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void painel_anotacoes_ParentChanged(object sender, EventArgs e)
        {
            
        }

        private void painel_anotacoes_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void painel_anotacoes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        private void painel_anotacoes_Validated(object sender, EventArgs e)
        {
            
        }

        private void painel_anotacoes_Resize(object sender, EventArgs e)
        {
     
        }

        private void painel_anotacoes_BackColorChanged(object sender, EventArgs e)
        {

            painel_anotacoes.BackColor = System.Drawing.Color.White;
            carregaAnotacoes();
            
        }

        private void txt_anotacoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_anotacoes_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txt_anotacoes_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
