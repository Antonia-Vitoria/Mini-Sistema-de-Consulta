using System.Data.SqlClient;

namespace ProjetoClientes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try{
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(
                    "User Id=sa;Password=Dark2024$;"+
                    "Server=localhost\\SQLEXPRESS;" +
                    "Database=projetoclientes;" +
                    "Trusted_Connection=False;"
                );

            using (SqlConnection conexao = new SqlConnection(builder.ConnectionString)){
            
                string sql = "select * from clientes";
                using(SqlCommand comando = new SqlCommand (sql, conexao))
                {
                    conexao.Open();

                    using(SqlDataReader leitor = comando.ExecuteReader())
                    {
                        while(leitor.Read())
                        {
                            System.Console.WriteLine("Id: {0}", leitor["Id"]);
                             System.Console.WriteLine("nome: {0}", leitor["nome"]);
                              System.Console.WriteLine("email: {0}", leitor["email"]);
                        }
                    }
                        
                }
            }

        }
        catch(Exception e)
        {
            System.Console.WriteLine("Erro:"+ e.ToString());
        }
    }
}
