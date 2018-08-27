using System.Configuration;


namespace PracticeHtml.Repository
{
    public static class ConnectionString
    {
        public static string GetConnectionString()
        {            
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            return connectionString.ToString();
        }
    }
}