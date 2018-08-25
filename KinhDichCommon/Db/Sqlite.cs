using System;
using System.Data.SQLite;

namespace KinhDichCommon
{
    public static class Sqlite
    {
        private const string DatabaseFile = "KinhDich.sqlite";
        private static string DatabaseSource = $"Data Source={DatabaseFile};";

        public static void SetQueFromDb()
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
                                SetQue(QueDich.All[index], reader);

                                index++;
                            }
                        }

                        connection.Close(); // Close the connection to the database
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Cannot read Sqlite db.");
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
        }
    }
}
