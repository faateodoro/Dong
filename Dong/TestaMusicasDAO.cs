using System;
using System.Collections.Generic;
using System.Text;

namespace Dong
{
    partial class Program
    {
        private static void TestaMusicasDAO()
        {
            var artista = new Artista("Fabiano", "faateodoro@gmail.com", "Metal is the law!");
            var musica = new Musica("Die for metal", "Metal", DateTime.Now, true);
            var musicaInvalida = new Musica("Die for metal", "Metal", DateTime.Now, true);
            var musica2 = new Musica("Dying for metal", "Metal", DateTime.Now, true);

            var dao = new MusicasDAO();
            dao.Adicionar(artista, musica);

            // música com título diferente deve retornar sucesso
            try
            {
                dao.Adicionar(artista, musica2);
                Console.WriteLine("Sucesso: Música adicionada com sucesso!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Falha: {e.Message}");
            }

            // Música com título igual deve retornar erro
            try
            {
                dao.Adicionar(artista, musicaInvalida);
                Console.WriteLine("Falha: Música adicionada com sucesso!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Sucesso: {e.Message}");
            }
        }
    }
}
