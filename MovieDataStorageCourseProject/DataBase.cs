using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MovieDataStorageCourseProject
{
    public class DataBase
    {
        private const string connectionString =
            @"Data Source=DESKTOP-HBI6ESF;Initial Catalog=MovieDataStorageDB;Integrated Security=True";

        public DataTable GetAllFilms()
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Films", connection);
                sqlDataAdapter.Fill(dataSet);
            }

            return dataSet.Tables[0];
        }

        public DataTable GetAllPersons()
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Persons", connection);
                sqlDataAdapter.Fill(dataSet);
            }

            return dataSet.Tables[0];
        }

        public DataTable GetFilmsByFilter(string namePart, int yearFrom, int yearTo)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string cmdText = $"SELECT * FROM Films WHERE " +
                    $"name LIKE '%{namePart}%' AND " +
                    $"year_of_issue BETWEEN {yearFrom} AND {yearTo}";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmdText, connection);
                sqlDataAdapter.Fill(dataSet);
            }

            return dataSet.Tables[0];
        }

        public DataTable GetSelections()
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = "SELECT * FROM Selections";
                new SqlDataAdapter(cmdText, connection).Fill(dataSet);
            }

            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }

        public int CreateSelection(string name)
        {
            int id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                SqlDataReader reader;

                try
                {
                    command.CommandText = $"INSERT INTO Selections (name) VALUES ('{name}')";
                    command.ExecuteNonQuery();
                    command.CommandText = $"SELECT id FROM Selections WHERE name = '{name}'";
                    reader = command.ExecuteReader();
                    reader.Read();
                    id = reader.GetInt32(0);
                    reader.Close();
                    transaction.Commit();
                }
                catch (System.Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }

            return id;
        }

        public void RenameSelection(int id, string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = $"UPDATE Selections SET name = '{name}' WHERE id = {id}";
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSelection(SelectionInfo selectionInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = $"DELETE FROM Selections WHERE id = {selectionInfo.Id}";
                new SqlCommand(cmdText, connection).ExecuteNonQuery();
            }
        }

        public bool SelectionContainsFilm(int selectionId, int filmId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = 
                    $"SELECT * FROM SelectionsFilms " +
                    $"WHERE selection_id = {selectionId} AND film_id = {filmId}";

                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlDataReader reader = command.ExecuteReader();
                bool result = reader.HasRows;
                reader.Close();

                return result;
            }
        }

        public void AddFilmToSelection(int selectionId, int filmId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = $"INSERT INTO SelectionsFilms VALUES ({selectionId}, {filmId})";
                new SqlCommand(cmdText, connection).ExecuteNonQuery();
            }
        }

        public DataTable GetSelectionFilms(int selectionId)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        $"SELECT film_id FROM SelectionsFilms " +
                        $"WHERE selection_id = {selectionId}";

                    List<int> filmIds = new List<int>();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        filmIds.Add(reader.GetInt32(0));
                    }

                    reader.Close();

                    SqlDataAdapter adapter = new SqlDataAdapter();

                    foreach (int id in filmIds)
                    {
                        command.CommandText = $"SELECT * FROM Films WHERE id = {id}";
                        adapter.SelectCommand = command;
                        adapter.Fill(dataSet);
                    }

                    transaction.Commit();
                }
                catch (System.Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }

            return dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        }
    }
}
