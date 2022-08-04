/*using MedicationsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationsAPI.Data
{
    public class SQLRepository : IRepository
    {
        private readonly string _connectionString;
        //private readonly ILogger<SQLRepository> _logger;

        public SQLRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
    }

    public async Task<IEnumerable<Medicines>> GetMedicinesAsync()
    {
        List<Medicines> result = new();

        using SqlConnection connection = new(_connectionString);
        await connection.OpenAsync();

        string cmdText = "SELECT Id, Name, Description, Amount, Tablets, Price FROM MedicinesDb;";

        using SqlCommand cmd = new(cmdText, connection);

        using SqlDataReader reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            int id = reader.GetInt32(0);
            string name = reader.GetString(1);
            string description = reader.GetString(2);
            string amount = reader.GetString(3);
            string tablets = reader.GetInt32(4);
            string price = reader.GetString(5);

        }

        return result;
    }
}*/
