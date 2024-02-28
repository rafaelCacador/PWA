using Dapper;

using Microsoft.Data.Sqlite;


using(var conexao = new SqliteConnection(@"Data Source=contato.db")){

    conexao.Open();

    var obj = new Contato
    {
        Id ="5",
        Nome = "Zé",
        Email = "ze@email.com"
    };



    const string sql = "INSERT INTO contato" +
                        "(id, nome, email)" +
                        "VALUES(@Id, @Nome, @Email)";
               
    conexao.Execute(sql, obj);

// Resumindo o uso do Dapper
// insert/update/ delete etc

//var count = connection.Execute(sql [,args]);

// consulta com múltiplas linhas

// IEnumerable<T> rows = connection.Query<T>(sql [, args]);

// consulta de única linha ({Single|First} [OrDefault])

//T row = connection.QuerySingle<T>(sql [, args]);


}
//  -----------------------------------------------------------------------------------
/*
using(var conexao = new SqliteConnection(@"Data Source=contato.db")){

    conexao.Open();
    var obj = new Contato
    {
        Id ="5",
        Nome = "Zé",
        Email = "ze@email.com"
    };

    //Reflection

    var tipo = obj.GetType();
    Console.WriteLine(tipo.FullName);

    foreach (var prop in tipo.GetProperties())
    {
        Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
    }
}
*/

//--------------------------------------------------------------------------------------------

/*
    var prop = tipo.GetProperty("Email");
    if(prop != null ){
        Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
    }
*/

/*
using(var conexao = new SqliteConnection(@"Data Source=contato.db")){

    conexao.Open();

    var obj = new Contato
    {
        Id ="5",
        Nome = "Zé",
        Email = "ze@email.com"
    };



    const string sql = "INSERT INTO contato" +
                        "(id, nome, email)" +
                        "VALUES(@Id, @Nome, @Email)";
               
    conexao.Execute(sql, obj);



    var cmd = conexao.CreateCommand();

    cmd.CommandText = "SELECT * FROM contato";

    var dr = cmd.ExecuteReader();

    while(dr.Read()){
        Console.WriteLine($"{dr["nome"]}: {dr["email"]}");
    }

    dr.Close();
}
*/