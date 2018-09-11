using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace KinhDichCommon
{
    public static class Sqlite
    {
        private static string DatabaseSource = @"Data Source=.\KinhDich.sqlite;";

        public static void LoadQueInfoFromDb()
        {
            try
            {
                // Connect to the database 
                using (SQLiteConnection connection = new SQLiteConnection(DatabaseSource))
                {
                    // Create a database command
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        connection.Open();

                        command.CommandText = "SELECT * FROM Que ORDER BY ID ASC";

                        int index = 0;
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SetQue(Que.All[index], reader);

                                index++;
                            }
                        }

                        connection.Close(); // Close the connection to the database
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot read Sqlite db: {ex.ToString()}");
            }
        }

        public static void UpdateQueBackToDb(List<Que> listQue)
        {
            try
            {
                // Connect to the database 
                using (SQLiteConnection connection = new SQLiteConnection(DatabaseSource))
                {
                    connection.Open();


                    foreach (var que in listQue)
                    {
                        UpdateDb(connection, que);
                    }

                    connection.Close(); // Close the connection to the database
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot read Sqlite db: {ex.ToString()}");
            }
        }

        private static void UpdateDb(SQLiteConnection connection, Que que)
        {
            // Create a database command
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = $"Update Que SET NgoaiQuaiId={que.NgoaiQuai.Id}, NoiQuaiId={que.NoiQuai.Id} WHERE ID = {que.Id}";

                var result = command.ExecuteNonQuery();
            }
        }

        private static void SetQue(Que que, SQLiteDataReader reader)
        {
            que.Id = Int32.Parse((reader["Id"].ToString()));
            que.QueId = Int32.Parse((reader["QueId"].ToString()));
            que.Name = reader["Name"].ToString();
            que.NameShort = reader["NameShort"].ToString();
            que.NameChinese = reader["NameChinese"].ToString();
            que.Desc = reader["Desc"].ToString();
            que.Url = reader["Url"].ToString();
            que.TuongQue = reader["TuongQue"].ToString();
            que.EnglishName = reader["EnglishName"].ToString();
            que.Unicode = reader["Unicode"].ToString();
        }
    }
}
