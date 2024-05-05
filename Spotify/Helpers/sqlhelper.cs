using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
namespace Spotify.Helpers
{
    public class sqlhelper
    {
        const string connectionString= @"Server=DESKTOP-8QLA9CR\SQLEXPRESS;Database=Spotify;Trusted_Connection=True;";
        public static DataTable ExecuteQuery(string query)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
            
        }
        
        public static int Execute(string query)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand cmd = new SqlCommand(query, conn);

            return cmd.ExecuteNonQuery();

        }

        public static string HashPassword(string password)
        {
            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.Default.GetBytes(password)));
        }

        public static DataTable GetAll(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";

            return ExecuteQuery(query);
        }
        public static DataTable GetById(string tableName, int id)
        {
            string query = $"SELECT * FROM {tableName} WHERE Id = @Id";

            return ExecuteQuery(query);
        }
        public static void Delete(string tableName, int id)
        {
            SqlParameter parameterId = new SqlParameter("@Id", id);
            string query = $"DELETE FROM {tableName} WHERE Id = @Id";
            ExecuteQuery(query);
        }
        //create men ele fikirlesirem ki addi onuda qeytiyadan kecende yaradiram isdifadecileri 
        

    }
}
