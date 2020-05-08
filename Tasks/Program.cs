using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static List<string> paginas = new List<string>();

        static void Main(string[] args)
        {
            // Exemplo 1
             MultiTasks();

            // Exemplo 2
            MultiDownload();

            Console.ReadKey();
        }

        static void MultiTasks()
        {
            List<Task> lista = new List<Task>();

            lista.Add(Task.Factory.StartNew(ExecutarTask));
            lista.Add(Task.Factory.StartNew(ExecutarTask));
            lista.Add(Task.Factory.StartNew(ExecutarTask));

            Task.WaitAll(lista.ToArray());

            Console.WriteLine("Fim do fluxo de MultiTasks");
        }

        static void ExecutarTask()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Task({Task.CurrentId}) - Numero: {i}");
            }
        }

        static void MultiDownload()
        {
            Console.WriteLine("Iniciando Downloads");

            string[] enderecos = { "http://www.google.com.br", "https://www.speedtest.net/pt"};

            var lista = from end in enderecos select DownloadPagina(end);

            Task.WaitAll(lista.ToArray());

            Console.WriteLine("Downloads Finalizados.");
        }

        static async Task DownloadPagina(string endereco)
        {
            using (var client = new WebClient())
            {
                var html = await client.DownloadStringTaskAsync(endereco);
                paginas.Add(html);
                Console.WriteLine($"Download do endereço {endereco} Finalizado.");
            }
        }
    }
}
