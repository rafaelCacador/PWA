using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtletaModel;

namespace AtletaInfra.DAOs
{
    public class AtletaDAO : BaseDAO<Atleta>
    {
        public override string NomeTabela => "atleta";

        public override Mapa[] Mapas => new Mapa[]
        {
            new() { Propriedade = "Id", Campo = "id" },
            new() { Propriedade = "Nome", Campo = "nome" },
            new() { Propriedade = "Altura", Campo = "altura" },
            new() { Propriedade = "Peso", Campo = "peso" }
        };
    }
}