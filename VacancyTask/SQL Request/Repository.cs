using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace VacancyTask.SQL_Request
{
    class Repository
    {
        private string ConnectionString = "SomeString";
        public IList<ReturnDTO> Request()
        {
            using var connection = new SqlConnection(ConnectionString);
            return connection.Query("SELECT * productname FROM products LEFT JOIN categories ON products.categoryid = categories.id").ToList();
        }
    }
}
