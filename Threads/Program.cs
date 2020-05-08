using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static object ThreadControle = 0;
        static void Main(string[] args)
        {
            for(int i=1; i<5; i++)
            {
                Thread t = new Thread(ExecutarRepeticao);
                
                // false - O programa encerra apenas quando todas as Threads forem finalizadas
                // true  - O programaa encerra quando o fluxo principal acabar
                t.IsBackground = true;

                t.Start(i);
            }

            //t.Join() - Espera terminar para seguir
            
            Console.ReadKey();
        }

        static void ExecutarRepeticao(object index)
        {
            Console.WriteLine($"Inicio da Thread({Thread.CurrentThread.ManagedThreadId}): {DateTime.Now}");

            for(int i=0; i<1000; i++)
            {
                // Lock ajuda a não sobrecarregar recursos de IO evitando que todas as Thread acessem ao mesmo tempo
                lock (ThreadControle)
                {
                    Console.WriteLine($"Thread({Thread.CurrentThread.ManagedThreadId}) / Index({index}) - Numero: {i}");
                }
            }

            Console.WriteLine($"Fim da Thread({Thread.CurrentThread.ManagedThreadId}): {DateTime.Now}");
        }
    }
}
