using Projeto_1.Model;
using Sistema_de_Cadastro.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cadastro.controller
{
    internal class ControllerJogadores
    {
        public void EnviarBanco()
        {
            SqlConnection cn = new SqlConnection(conexao.Conectar());
            SqlCommand cmd = new SqlCommand("tbjogadores" cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Jogadores.Nome);
                cmd.Parameters.AddWithValue("@posicao", Jogadores.Posicao);
                cmd.Parameters.AddWithValue("@idade", Jogadores.Idade);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso");
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
