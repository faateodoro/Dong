using System;
using System.Text.RegularExpressions;

namespace Dong
{
    public class Artista
    {
        public Artista(string nome, string email, string descricao)
        {
            Nome = nome;
            Email = email;
            Descricao = descricao;
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio ou nulo.");
                }
                _nome = value; 
            }
        }
        
        private string _email;
        public string Email
        {
            get { return _email; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("E-mail não pode ser vazio ou nulo.");
                }
                if(!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    throw new ArgumentException("Email está com formato inválido.");
                }
                _email = value; 
            }
        }
        
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Adescrição não pode ser vazia ou nula.");
                }
                if (value.Length>500)
                {
                    throw new ArgumentException("A descrição contém mais de 500 caracteres.");
                }
                _descricao = value; 
            }
        }
        
        public override string ToString()
        {
            return $"Artista: {_nome}, Email: {_email}, Descrição: {_descricao}";
        }

    }
}
