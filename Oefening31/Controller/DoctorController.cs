//Nikodem Bielaga
// 14-04-2025
//Oefening23
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
    public class DoctorController
    {
        private string conString = "Data Source=LAPTOP-889JICD3;Initial Catalog=DoctorWho;Integrated Security=True;";

        public List<DoctorModel> ReadAll()
        {
            List<DoctorModel> doctorList = new List<DoctorModel>();
            string sqlQuery = "SELECT * FROM tblDoctor";

            // Start een SQL Connection en .open() deze direct.
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Start een SQL Command
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Start de connectie (verbinding) met de database
                    connection.Open();

                    // Voer het SqlCommand uit
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Het (nog te vullen) bestelling object declareren en intialiseren 
                        DoctorModel doctorItem = new DoctorModel();

                        doctorItem.DoctorID = (int)reader["DoctorId"];
                        // Uitlezen nullable kolom DoctorNumber
                        if (!reader.IsDBNull(1))
                        {
                            doctorItem.DoctorNumber = (int)reader["DoctorNumber"];
                        }
                        else
                        {
                            doctorItem.DoctorNumber = 0;
                        }

                        if (!reader.IsDBNull(2))
                        {
                            doctorItem.DoctorName = (string)reader["DoctorName"];
                        }
                        else
                        {
                            doctorItem.DoctorName = "";
                        }
                        // Uitlezen nullable kolom BirthDate
                        if (!reader.IsDBNull(3))
                        {
                            doctorItem.BirthDate = (DateTime)reader["BirthDate"];
                        }
                        else
                        {
                            doctorItem.BirthDate = System.DateTime.MinValue;
                        }

                        // Uitlezen nullable kolom FirstEpisodeDate
                        if (!reader.IsDBNull(4))
                        {
                            doctorItem.FirstEpisodeDate = (DateTime)reader["FirstEpisodeDate"];
                        }
                        else
                        {
                            doctorItem.FirstEpisodeDate = System.DateTime.MinValue;
                        }

                        // Uitlezen nullable kolom LastEpisodeDate
                        if (!reader.IsDBNull(5))
                        {
                            doctorItem.LastEpisodeDate = (DateTime)reader["LastEpisodeDate"];
                        }
                        else
                        {
                            doctorItem.LastEpisodeDate = System.DateTime.MinValue;
                        }

                        // Voeg de bestelling toe aan de List<>
                        doctorList.Add(doctorItem);
                    }
                }
            }

            return doctorList;
        }
        // Methode om de gegevens van een arts bij te werken in de database
        public int Update(DoctorModel doctor)
        {
            // De SQL-query die wordt uitgevoerd om de gegevens van de arts bij te werken
            // De parameters worden later dynamisch ingevuld om SQL-injecties te voorkomen
            string query = @"UPDATE tblDoctor SET 
                 DoctorName = @Name,            
                 BirthDate = @BirthDate,       
                 FirstEpisodeDate = @FirstEpisodeDate, 
                 LastEpisodeDate = @LastEpisodeDate 
                 WHERE DoctorNumber = @DoctorNumber"; 

            // De 'using' blokken zorgen ervoor dat de resources (verbinding en command) automatisch worden vrijgegeven wanneer ze niet meer nodig zijn
            using (SqlConnection conn = new SqlConnection(conString)) // Aangemaakt een nieuwe SQL-verbinding met de opgegeven verbindingsstring
            using (SqlCommand cmd = new SqlCommand(query, conn)) // Een SQL-commando object met de query en de verbinding
            {
                // Voeg de waarden van het 'doctor' object toe aan de query parameters
                cmd.Parameters.AddWithValue("@Name", doctor.DoctorName); // Arts naam
                cmd.Parameters.AddWithValue("@BirthDate", doctor.BirthDate); // Geboortedatum van de arts
                cmd.Parameters.AddWithValue("@FirstEpisodeDate", doctor.FirstEpisodeDate); // Eerste episode datum
                cmd.Parameters.AddWithValue("@LastEpisodeDate", doctor.LastEpisodeDate); // Laatste episode datum
                cmd.Parameters.AddWithValue("@DoctorNumber", doctor.DoctorNumber); // Arts nummer als zoekparameter

                // Open de verbinding met de database
                conn.Open();

                // Voer de query uit en geef het aantal rijen terug dat is gewijzigd in de database
                return cmd.ExecuteNonQuery(); // Aantal gewijzigde rijen in de database (meestal 1 als er succesvol iets is geüpdatet)
            }
        }

        public bool Delete(DoctorModel doctor)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "DELETE FROM tblDoctor WHERE DoctorId = @DoctorId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorId", doctor.DoctorID); // let op correcte naam

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // true als succesvol verwijderd
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // foreign key constraint violation
                    {
                        throw new InvalidOperationException("Deze doctor kan niet verwijderd worden omdat hij gekoppeld is aan episodes.", ex);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
    }
}
