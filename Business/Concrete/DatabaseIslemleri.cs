namespace Business.Concrete
{
    public static class DatabaseIslemleri
    {
        public static void CreateDatabase()
        {
            Database.Operations.DatabaseOperations.Create();
        }
        public static string ConnectionStringofConnection()
        {
            string ConnectionString = Database.Operations.DatabaseOperations.ConnectionStringOfConnection();
            return ConnectionString;
        }
    }
}
