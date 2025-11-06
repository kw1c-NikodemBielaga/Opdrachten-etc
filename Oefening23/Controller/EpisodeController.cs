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
    }
}