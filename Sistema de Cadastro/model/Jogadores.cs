using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Projeto_1.Model
{
    internal class Jogadores
    {
        private static int codigo;
        private static string nome;
        private static string posicao;
        private static string idade;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Posicao { get => posicao; set => posicao = value; }
        public static string Idade { get => idade; set => idade = value; }
    }
}