using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FirstProjectASP.Models
{
    public class Woker
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public List<WokerAccesLayer> GetDateWoker()
        {
            List<WokerAccesLayer> wokers = new List<WokerAccesLayer>();

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
               // string sqlExpression = "SELECT * FROM woker";
                SqlCommand sqlCommand = new SqlCommand("woker_getdate", connection);
                connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    WokerAccesLayer wokerAcces = new WokerAccesLayer();
                    wokerAcces.ID = Convert.ToInt32(dataReader.GetValue(0).ToString());
                    wokerAcces.LastName = dataReader.GetValue(1).ToString();
                    wokerAcces.FirstName = dataReader.GetValue(2).ToString();
                    wokerAcces.Patronymic = dataReader.GetValue(3).ToString();
                    wokerAcces.Startwork = Convert.ToDateTime(dataReader.GetValue(4).ToString());
                    wokerAcces.Position = dataReader.GetValue(5).ToString();
                    wokerAcces.Company = dataReader.GetValue(6).ToString();
                    wokers.Add(wokerAcces);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            return wokers;



        }

    }
}