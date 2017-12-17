using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Projeto_Posts_
{

    class WebServiceAnotacoes
    {

        static HttpClient client = new HttpClient();


        static async Task<Uri> CriarAnotacaoAsync(Anotacao anotacao)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/products", anotacao);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        public static async Task<Anotacao> SelecionarAnotacaoAsync(string path)
        {
            Anotacao anotacao = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                anotacao = await response.Content.ReadAsAsync<Anotacao>();
            }
            return anotacao;
        }

        static async Task<Anotacao> AtualizarAnotacaoAsync(Anotacao anotacao)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/products/{anotacao.Cod}", anotacao);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            anotacao = await response.Content.ReadAsAsync<Anotacao>();
            return anotacao;
        }

        static async Task<HttpStatusCode> ExcluirAnotacaoAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/products/{id}");
            return response.StatusCode;
        }

        static void MostrarAnotacao(Anotacao anotacao)
        {
            Console.WriteLine($"Cod: {anotacao.Cod}\tConteúdo: " +
                $"{anotacao.Conteudo}\tHorário: {anotacao.Horario}");
        }

        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://webserverlab.000webhostapp.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new product
                Anotacao anotacao;

                // Get the product
                anotacao = await SelecionarAnotacaoAsync("api/anotacao/ler.php");
                MostrarAnotacao(anotacao);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

    }
}
