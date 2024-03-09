using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula03.models;
using Dapper;
using Microsoft.Data.Sqlite;

namespace Aula03.daos;

public class ProdutoDAO : BaseDAO<Produto>
{
    public override string NomeTabela => "produto";

    public override Mapa[] Mapas => new Mapa[]
    {
        new() { Campo = "descricao", Propriedade = "Descricao" },
        new() { Campo = "codigo", Propriedade = "Codigo" },
        new() { Campo = "preco", Propriedade = "Preco" }
    };

    public IList<Produto> RetornarPorParteDescricao(string parteDescricao)
    {
        using(var conexao = new SqliteConnection("Data Source=db/dados.db"))
        {
            conexao.Open();
            
            string sql = $"SELECT * FROM {NomeTabela} WHERE descricao LIKE @ParteDescricao";

            var objetos = conexao.Query<Produto>(sql, new { ParteDescricao = parteDescricao });

            return objetos.ToList();
        }
    }
}