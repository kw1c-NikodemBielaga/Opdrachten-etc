//Nikodem Bielaga
// 14-04-2025
//Oefening32
using DrWho.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrWho.Controller
{
    public class EpisodeController
    {
        private string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=DoctorWho;Integrated Security=True;";

        public List<EpisodeModel> ReadAll()
        {
            List<EpisodeModel> episodeList = new List<EpisodeModel>();
            string sqlQuery = @"
                                SELECT e.EpisodeId, e.SeriesNumber,                           e.EpisodeNumber, e.Title, 
                                e.EpisodeDate, e.EpisodeType, e.Notes,
                                a.AuthorId, a.AuthorName,
                                d.DoctorId, d.DoctorName, d.DoctorNumber
                                FROM tblEpisode e
                                LEFT JOIN tblAuthor a ON e.AuthorId = a.AuthorId
                                LEFT JOIN tblDoctor d ON e.DoctorId = d.DoctorId";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Stap 1: Maak een nieuw AuthorModel object aan
                        AuthorModel author = new AuthorModel();
                        author.AuthorId = (int)reader["AuthorId"];
                        author.AuthorName = (string)reader["AuthorName"];

                        // Stap 2: Maak een nieuw DoctorModel object aan
                        DoctorModel doctor = new DoctorModel();
                        doctor.DoctorID = (int)reader["DoctorId"];
                        doctor.DoctorName = reader["DoctorName"] == DBNull.Value ? null : (string)reader["DoctorName"];
                        doctor.DoctorNumber = reader["DoctorNumber"] == DBNull.Value ? 0 : (int)reader["DoctorNumber"];

                        // Stap 3: Maak een nieuw EpisodeModel object aan
                        EpisodeModel episodeItem = new EpisodeModel();
                        episodeItem.EpisodeId = reader["EpisodeId"] == DBNull.Value ? 0 : (int)reader["EpisodeId"];
                        episodeItem.SeriesNumber = reader["SeriesNumber"] == DBNull.Value ? 0 : (int)reader["SeriesNumber"];
                        episodeItem.EpisodeNumber = reader["EpisodeNumber"] == DBNull.Value ? 0 : (int)reader["EpisodeNumber"];
                        episodeItem.Title = reader["Title"] == DBNull.Value ? null : (string)reader["Title"];
                        episodeItem.EpisodeDate = (DateTime)reader["EpisodeDate"];
                        episodeItem.EpisodeType = reader["EpisodeType"] == DBNull.Value ? null : (string)reader["EpisodeType"];
                        episodeItem.Notes = reader["Notes"] == DBNull.Value ? null : (string)reader["Notes"];

                        // Stap 4: Koppel de nested objecten aan het EpisodeModel
                        episodeItem.Autor = author;
                        episodeItem.Doctor = doctor;

                        // Stap 5: Voeg het object toe aan de lijst
                        episodeList.Add(episodeItem);
                    }
                }
            }
            return episodeList;
        }

        public int Delete(EpisodeModel episode)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "DELETE FROM tblEpisode WHERE EpisodeId = @EpisodeId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EpisodeId", episode.EpisodeId);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;  // Aantal verwijderde rijen (int)
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        throw new InvalidOperationException("Verwijderen mislukt: Er zijn nog gerelateerde gegevens aanwezig.", ex);
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int Update(EpisodeModel episode)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = @"
            UPDATE tblEpisode
            SET SeriesNumber = @SeriesNumber,
                EpisodeNumber = @EpisodeNumber,
                Title = @Title,
                EpisodeDate = @EpisodeDate,
                EpisodeType = @EpisodeType,
                Notes = @Notes,
                AuthorId = @AuthorId,
                DoctorId = @DoctorId
            WHERE EpisodeId = @EpisodeId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parameters invullen
                    command.Parameters.AddWithValue("@EpisodeId", episode.EpisodeId);
                    command.Parameters.AddWithValue("@SeriesNumber", episode.SeriesNumber);
                    command.Parameters.AddWithValue("@EpisodeNumber", episode.EpisodeNumber);
                    command.Parameters.AddWithValue("@Title", episode.Title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@EpisodeDate", episode.EpisodeDate);
                    command.Parameters.AddWithValue("@EpisodeType", episode.EpisodeType ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Notes", episode.Notes ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@AuthorId", episode.Autor?.AuthorId ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@DoctorId", episode.Doctor?.DoctorID ?? (object)DBNull.Value);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                    catch (SqlException ex)
                    {
                        throw new InvalidOperationException("Fout bij het bijwerken van de episode.", ex);
                    }
                }
            }
        }


    }

}
