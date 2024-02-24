//dotnet add package Microsoft.Data.Sqlite

using Microsoft.Data.Sqlite;

using(var conexao = new SqliteConnection(@"Data Source=contato.db")){
    conexao.Open();

    var cmd = conexao.CreateCommand();

    cmd.CommandText = "SELECT * FROM contato";

    var dr = cmd.ExecuteReader();

    while(dr.Read()){
        Console.WriteLine($"{dr["nome"]}: {dr["email"]}");
    }

    dr.Close();
}

/*
using(var conexao = new SqliteConnection(@"Data Source=contato.db")){
    conexao.Open();

    var cmd = conexao.CreateCommand();
    
    cmd.CommandText = "INSERT INTO contato" + 
                    "(id,nome,email)" +
                    "VALUES (@id,@nome,@email)";

                
    
    /*
    cmd.CommandText = "UPDATE contato" +
            "(id,nome,email)" +
            "SET (@id,@nome,@email)";

   
    cmd.CommandText = "DELETE FROM contato" + 
                    "(id,nome,email)" +
                    "WHERE (@id,@nome,@email)";
    
     */
    /*
    cmd.Parameters.AddWithValue("@id",4);
    cmd.Parameters.AddWithValue("@nome", 
                                "Daniel");
    cmd.Parameters.AddWithValue("@email",
                                "daniel@email.com");

    var retorno = cmd.ExecuteNonQuery(); //Executa o comando e retorna o numero de linhas afetas

    Console.WriteLine($"Comando executado. {retorno} linhas afetadas");    


*/