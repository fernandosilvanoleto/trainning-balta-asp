using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];
            Console.Clear();
            
            try // TENTE EXECUTAR O CÓDIGO AQUI
            {
                /*for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }*/
                Cadastrar("Fernando");
            }
            catch(IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista!");
            }
            catch(ArgumentNullException ex) 
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto!");
            }
            catch(MinhaException ex) 
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.AconteceuQuando);
                Console.WriteLine("Execução customizada");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
            finally // SEMPRE ISSO ACONTECE: ACONTECENDO ERRO OU NÃO
            {
                Console.WriteLine("Fim!");
            }
        }

        private static void Cadastrar(string texto){
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException(DateTime.Now);
            } else {
                Console.WriteLine(texto);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                AconteceuQuando = date;
            }
            public DateTime AconteceuQuando { get; set; }
        }
    }
}
