using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using T8_VoetbalToernooi.Model;

namespace T8_VoetbalToernooi.Controller;

 public class TeamController
{
    /*
       maker Niek van der heijden
       datum : 10-06-25
    */
    //private static string connectionString = ConfigurationManager.ConnectionStrings["ShopDatabaseConnectionString"].ConnectionString;
    private string connectionString = @"Data Source=NIEK_LAPTOP;Initial Catalog=T8_Voetbaltoernooi;Integrated Security=True;TrustServerCertificate=True";

    public List<TeamModel> Read()
    {
        List<TeamModel> Teams = new List<TeamModel>();
        Teams.Clear();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string sqlQuery = "SELECT * FROM Teams JOIN Docent ON Teams.DocentId = Docent.DocentId;";


            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TeamModel team = new TeamModel();
                    team.Id = (int)reader["TeamId"];
                    team.Name = (string)reader["TeamNaam"];
                    team.Score = (int)reader["Score"];
                    team.Docent = new DocentModel()
                    {
                        DocentId = (int)reader["DocentId"],
                        Naam = (String)reader["Naam"],
                        Email = (string)reader["Email"],
                        Rol = (string)reader["Rol"],
                    };
                    // toevoegen aan lijst

                    Teams.Add(team);
                }
            }
        }
        return Teams;
    }
    public List<DocentModel> ReadDocent()
    {
        List<DocentModel> docentList = new List<DocentModel>();
        docentList.Clear();
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string sqlQuery = "SELECT * FROM Docent"; // Haal alle docenten op
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

    public bool BestaatTeam(string Team)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(*) FROM Teams WHERE TeamNaam = @Team";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Team", Team);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    public int Create(TeamModel team)
    {
        int result = 0;
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string sqlQuery = "INSERT INTO Teams (TeamNaam, Score, DocentId) VALUES (@name, @score, @docentId)";

            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                command.Parameters.AddWithValue("@name", team.Name);
                command.Parameters.AddWithValue("@score", team.Score);
                command.Parameters.AddWithValue("@docentId", team.Docent.DocentId); 

                con.Open();
                result = command.ExecuteNonQuery();
            }
        }
        return result;
    }

    public int Delete(TeamModel team)
    {
        int result = 0;
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string sqlQuery = "DELETE FROM Teams WHERE TeamNaam = @Name AND Score = @Score AND DocentId = @DocentId";

            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                command.Parameters.AddWithValue("@Name", team.Name);
                command.Parameters.AddWithValue("@Score", team.Score);
                command.Parameters.AddWithValue("@DocentId", team.Docent.DocentId);

                con.Open();
                result = command.ExecuteNonQuery();
            }
        }
        return result;
    }

}
