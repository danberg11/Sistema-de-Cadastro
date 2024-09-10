using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cadastro.model
{
    internal class conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\daniel.bnoliveira\source\repos\Sistema de Cadastro\Sistema de Cadastro\dados\Database1.mdf"";Integrated Security=True";
        }
    }
}
