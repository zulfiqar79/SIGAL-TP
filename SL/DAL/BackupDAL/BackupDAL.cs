using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.BackupDAL
{
    public class BackupDAL
    {
        public void RealizarBackup(string backupPath)
        {
            string efConnectionString = ConfigurationManager.ConnectionStrings["base_sigalEntities"].ConnectionString;
            var efBuilder = new EntityConnectionStringBuilder(efConnectionString);
            string sqlConnectionString = efBuilder.ProviderConnectionString;

            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();

                string rawDatabaseName = connection.Database;
                string databaseName = rawDatabaseName.Replace("]", "]]");

                string query = "BACKUP DATABASE [" + databaseName + "] TO DISK = @backupPath WITH FORMAT, INIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@backupPath", backupPath);
                    command.CommandTimeout = 300;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
