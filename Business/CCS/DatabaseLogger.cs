namespace Business.CCS
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged to database: " + message);
        }
    }


}
