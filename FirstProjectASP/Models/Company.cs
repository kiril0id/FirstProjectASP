using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FirstProjectASP.Models
{
    public class Company
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public List<CompanyAccesLayer> GetDateCompany()
        {
            List<CompanyAccesLayer> company = new List<CompanyAccesLayer>();

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
               
                SqlCommand sqlCommand = new SqlCommand("copmany_getdate", connection);
                connection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    CompanyAccesLayer companyAcces = new CompanyAccesLayer();
                    companyAcces.ID = Convert.ToInt32(dataReader.GetValue(0).ToString());
                    companyAcces.NameCompany = dataReader.GetValue(1).ToString();
                    companyAcces.LegalForm = dataReader.GetValue(2).ToString();

                    company.Add(companyAcces);
                }
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return company;
        }

    }
}