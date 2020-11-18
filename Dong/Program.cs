using System;
using System.Linq;

namespace Dong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando criação do artista com valores válidos
            try
            {
                new Artista("Wands do cavaco", "wandsdocavaco@alura.com.br", "O menino manja demais!");
                Console.WriteLine("Sucesso: Artista criado com os dados válidos.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha: {e.Message}");
            }

            // artista com nome vazio deve lançar erro
            try
            {
                new Artista("", "wandsdocavaco@alura.com.br", "O menino manja demais!");
                Console.WriteLine("Falha: Artista criado com o nome vazio.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // artista com nome nulo deve lançar erro
            try
            {
                new Artista(null, "wandsdocavaco@alura.com.br", "O menino manja demais!");
                Console.WriteLine("Falha: Artista criado com o nome nulo");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // artista com email vazio deve lançar erro
            try
            {
                new Artista("Wands do cavaco", "", "O menino manja demais!");
                Console.WriteLine($"Falha: Artista criado com email vazio.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");

            }

            // artista com email nulo deve lançar erro
            try
            {
                new Artista("Wands do cavaco", null, "O menino manja demais!");
                Console.WriteLine($"Falha: Artista criado com email nulo.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // artista com email inválido deve lançar erro
            try
            {
                new Artista("Wands do cavaco", "wandsdocavacoalura.com.br", "O menino manja demais!");
                Console.WriteLine($"Falha: Artista criado com email nulo.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // artista com email inválido deve lançar erro
            try
            {
                new Artista("Wands do cavaco", "wandsdocavaco@alura", "O menino manja demais!");
                Console.WriteLine($"Falha: Artista criado com email nulo.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // artista com descrição vazia deve lançar erro
            try
            {
                new Artista("Wands do cavaco", "wandsdocavaco@alura.com.br", "");
                Console.WriteLine($"Falha: Artista criado com email nulo.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // artista com descrição nula deve lançar erro
            try
            {
                new Artista("Wands do cavaco", "wandsdocavaco@alura.com.br", null);
                Console.WriteLine($"Falha: Artista criado com email nulo.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // artista com descrição com mais de 500 caracteres deve lançar erro
            try
            {
                new Artista("Wands do cavaco", "wandsdocavaco@alura.com.br", String.Concat(Enumerable.Repeat("a", 501)));
                Console.WriteLine($"Falha: Artista criado com email nulo.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }
        }
    }
}
