using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T8_VoetbalToernooi.Model;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Configuration;

namespace T8_VoetbalToernooi.Controller;

public class DocentController
{
    /*
        maker Niek van der heijden
        datum : 10-06-25
     */
    //private static string connectionString = ConfigurationManager.ConnectionStrings["ShopDatabaseConnectionString"].ConnectionString;
    private string connectionString = @"Data Source=NIEK_LAPTOP;Initial Catalog=T8_Voetbaltoernooi;Integrated Security=True;TrustServerCertificate=True";

    // Dit is het object waar de Studenten daadwerkelijk opgeslagen worden

    private List<DocentModel> docentList = new List<DocentModel>();
    public List<DocentModel> Read()
    {

        docentList.Clear(); // <<< voeg dit toe zodat je geen duplicaten krijgt

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string sqlQuery = "SELECT * FROM Docent";
            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DocentModel docent = new DocentModel();
                    docent.DocentId = (int)reader["DocentId"];
                    docent.Naam = (String)reader["Naam"];
                    docent.Email = (string)reader["Email"];
                    docent.Rol = (string)reader["Rol"];
                    docentList.Add(docent);
                }
            }
        }

        return docentList;
    }
    public bool BestaatDocent(string gebruikersnaam, string email)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(*) FROM Docent WHERE Naam = @Gebruikersnaam OR Email = @Email";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Gebruikersnaam", gebruikersnaam);
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    public int Create(DocentModel docent)
    {
        int result = 0;
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string sqlQuery = "INSERT INTO Docent (Naam, Email, Rol) VALUES (@naam, @email, @rol)";

            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                command.Parameters.AddWithValue("@naam", docent.Naam);
                command.Parameters.AddWithValue("@email", docent.Email);
                command.Parameters.AddWithValue("@rol", docent.Rol);

                con.Open();
                result = command.ExecuteNonQuery();
            }
        }
        return result;
    }
    public int Delete(int docentId)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();

            string sql = "DELETE FROM Docent WHERE DocentId = @id";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", docentId);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
