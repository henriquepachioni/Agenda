using Agenda.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Agenda.DAL
{
    public class Contatos
    {
        string _strConn;

        public Contatos()
        {
            _strConn = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        }
        public void Incluir(Contato contato)
        {
            using (var con = new SqlConnection(_strConn))
            {
                con.Execute("INSERT INTO Contato(Id, Nome) VALUES (@Id, @Nome)", new { contato.Id, contato.Nome });
            }
        }

        public Contato Obter(Guid id)
        {
            Contato contatoResultado;
            using (var con = new SqlConnection(_strConn))
            {
                contatoResultado = con.QueryFirst<Contato>("SELECT Id, Nome FROM Contato WHERE Id = @Id", new { Id = id });
            }

            return contatoResultado;
        }

        public List<Contato> ObterTodos()
        {
            var contatosResultado = new List<Contato>();
            using (var con = new SqlConnection(_strConn))
            {
                contatosResultado = con.Query<Contato>("SELECT Id, Nome FROM Contato").ToList();
            }
            return contatosResultado;
        }
    }
}
