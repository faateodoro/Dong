using System;

namespace Dong
{
    partial class Program
    {
        private static void TestaMusica()
        {
            // Música Com todos argumentos ok
            try
            {
                new Musica("Chorinho de Natal", "Samba", DateTime.Today, true);
                Console.WriteLine($"Sucesso: Música criada com sucesso.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha: {e.Message}");
            }

            // Música com nome nulo deve lançar erro
            try
            {
                new Musica(null, "Samba", DateTime.Today, true);
                Console.WriteLine("Falha: Música com nome nulo criada.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // Música com nome vazio deve lançar erro
            try
            {
                new Musica("", "Samba", DateTime.Today, true);
                Console.WriteLine("Falha: Música com nome vazio criada.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // Musica com gênero Nulo deve lançar erro
            try
            {
                new Musica("Chorinho de Natal", null, DateTime.Today, true);
                Console.WriteLine($"Falha: Música com gênero nulo criada.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }

            // Musica com gênero vazio deve lançar erro
            try
            {
                new Musica("Chorinho de Natal", "", DateTime.Today, true);
                Console.WriteLine($"Falha: Música com gênero vazio criada.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }
        }
    }
}
