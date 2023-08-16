using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Game_App.Backend;

namespace Video_Game_App.Management
{
    internal class DAO
    {
        public string loggedInUsername;
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["VideoGameDB"].ConnectionString;
        }

        public bool CheckUserExists(string usernames, string passwords)
        {
            string connectionString = GetConnectionString();
            bool userExists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM dbo.Users WHERE usernames = @usernames AND passwords = @passwords";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usernames", usernames);
                    command.Parameters.AddWithValue("@passwords", passwords);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    userExists = count > 0;
                    loggedInUsername = usernames;
                }
            }

            return userExists;
        }

        public bool CheckPlayerExists(string usernames)
        {
            string connectionString = GetConnectionString();
            bool playerExists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM dbo.Player WHERE usernames = @usernames";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usernames", usernames);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    playerExists = count > 0;
                }
            }

            return playerExists;
        }

        public bool CheckAdministratorExists(string usernames)
        {
            string connectionString = GetConnectionString();
            bool administratorExists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM dbo.Administrator WHERE usernames = @usernames";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usernames", usernames);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    administratorExists = count > 0;
                }
            }

            return administratorExists;
        }

        public void InsertNewVideoGame(VideoGame videoGame)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO VideoGame (names, creditCost, console) " +
                               "VALUES (@names, @creditCost, @console)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@names", videoGame.names);
                    command.Parameters.AddWithValue("@creditCost", videoGame.creditCost);
                    command.Parameters.AddWithValue("@console", videoGame.console);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteVideoGame(string gameName, string console)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM VideoGame WHERE names = @gameName AND console = @console";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@gameName", gameName);
                    command.Parameters.AddWithValue("@console", console);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ModifyVideoGame(string oldGameName, string oldConsole, string newGameName, string newConsole, int newCreditCost)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE VideoGame SET names = @newGameName, console = @newConsole, creditCost = @newCreditCost WHERE names = @oldGameName AND console = @oldConsole";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newGameName", newGameName);
                    command.Parameters.AddWithValue("@newConsole", newConsole);
                    command.Parameters.AddWithValue("@newCreditCost", newCreditCost);
                    command.Parameters.AddWithValue("@oldGameName", oldGameName);
                    command.Parameters.AddWithValue("@oldConsole", oldConsole);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        public List<VideoGame> GetAllVideoGames()
        {
            List<VideoGame> videoGames = new List<VideoGame>();
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM VideoGame";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VideoGame videoGame = new VideoGame
                            {
                                names = reader["names"].ToString(),
                                creditCost = Convert.ToInt32(reader["creditCost"]),
                                console = reader["console"].ToString()
                            };

                            videoGames.Add(videoGame);
                        }
                    }
                }
            }

            return videoGames;
        }

        public void InsertNewCopy(Copy copy)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Copys (usernames, names) VALUES (@usernames, @names)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usernames", copy.usernames);
                    command.Parameters.AddWithValue("@names", copy.names);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertNewUser(string usernames, string passwords)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (usernames, passwords) VALUES (@usernames, @passwords)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usernames", usernames);
                    command.Parameters.AddWithValue("@passwords", passwords);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertNewPlayer(Player player)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Player (usernames, crédit, pseudo, registrationDate, dateOfBirth) " +
                               "VALUES (@usernames, @crédit, @pseudo, @registrationDate, @dateOfBirth)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usernames", player.usernames);
                    command.Parameters.AddWithValue("@crédit", player.crédit);
                    command.Parameters.AddWithValue("@pseudo", player.pseudo);
                    command.Parameters.AddWithValue("@registrationDate", player.registrationDate);
                    command.Parameters.AddWithValue("@dateOfBirth", player.dateOfBirth);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
