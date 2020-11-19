using Database.Context;
namespace Database.Operations
{
    public static class DatabaseOperations
    {
        public static void Create()
        {
            using (var context = new DbTarimContext())
            {
                if (!context.Database.Exists())
                {
                    context.Database.Create();
                    context.SaveChanges();
                }
            }
        }
      
        public static string ConnectionStringOfConnection()
        {
            string Datasource,Database;
            using (Context.DbTarimContext db = new DbTarimContext())
            {
                
                Datasource=db.Database.Connection.DataSource;
                Database = db.Database.Connection.Database;
            }
            return $"Datasource: {Datasource} Database: {Database}";
        }
    }
}
