using System;
using System.Globalization;
using System.Text;

namespace AppExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Guid => gerar um valor randômico
            var id = Guid.NewGuid();
            id.ToString();

            //Console.WriteLine(id);

            /*
            // INTERPOLAÇÃO/JUNÇÃO DE STRINGS

            var price = 10.2;
            //var texto = "O preço do produto é " + price + " na promoção!!!";
            //var texto = string.Format("O preço do produto é {0} na promoção", price);
            var texto = $"O preço do produto é {price} na promoção";
            var texto_multi_linhas = $@"O preço do produto é {price}
            apenas na promoção";
            Console.WriteLine(texto);
            Console.WriteLine(texto_multi_linhas);
            */

            /*var texto = "Testando";
            Console.WriteLine(texto.CompareTo("testando")); // O RESULT É DIFERENTE => 0, PQ O C# É CASE SENSITIVE
            Console.WriteLine(texto.CompareTo("Testando")); // O RESULT É IGUAL => 0, MESMO RESULTADO
            */

            /*
            
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texte"));

            Console.WriteLine(texto.EndsWith("texto"));
            Console.WriteLine(texto.EndsWith("Texto"));
            Console.WriteLine(texto.EndsWith("xpro"));
            */

            /*
            // objeto equals
            var texto = "Este texto é um teste!";
            Console.WriteLine(texto.Equals("Este texto é um teste!"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste!", StringComparison.OrdinalIgnoreCase)); // OrdinalIgnoreCase -> ignora os maiusculos e minusculo acentos
            */

            /*
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.Insert(5, "AQUI "));
            Console.WriteLine(texto.Remove(5,6));
            Console.WriteLine(texto.Length);
            */

            /*
            var texto = "Este texto é um teste"; 
            Console.WriteLine(texto.Replace("e", "e"));

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            var resultado = texto.Substring(5, 5);
            Console.WriteLine(resultado);

            Console.WriteLine(texto.Trim()); // tirar os espaços em branco do começo e fim
            */
            
            /*
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste"); 
            texto.Append(" aqui");

            Console.WriteLine(texto.ToString());
            */

            /*

            XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            
            // APRENDENDO SOBRE OS TIPOS DE MOEDAS
            // É RECOMENDADO TRABALHAR COM O DECIMAL PARA VALORES DE MOEDAS
            decimal valor = 10000.41m;

            // PARA CULTURA DO PAÍS
            Console.WriteLine(valor);
            Console.WriteLine(valor.ToString(
               "C",
               CultureInfo.CreateSpecificCulture("pt-BR")
               )
               );

            Console.WriteLine(valor.ToString(
               "E04",
               CultureInfo.CreateSpecificCulture("pt-BR")
               )
               );

            Console.WriteLine(
                Math.Round(valor)
            );

            Console.WriteLine(
                Math.Ceiling(valor) // ARRENDODAR PARA CIMA
            );

            Console.WriteLine(
                Math.Floor(valor) // ARRENDODAR PARA BAIXO
            );
            */

            /*
            // TRABALHANDO COM LISTA EM C# E ASP NET
            
            */

            /*
            var meuArray = new int[5] {23, 42, 13, 54, 11};
            meuArray[0] = 12;

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }
            */

            var primeiro = new int[4];

            var segundo = primeiro;

            primeiro[0] = 23;

            Console.WriteLine(segundo[0]);
        }
    }
}
