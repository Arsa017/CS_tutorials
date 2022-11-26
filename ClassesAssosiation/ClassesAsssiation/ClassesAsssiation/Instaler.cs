namespace ClassesAsssiation
{
    public class Instaler
    {
        private readonly Logger _logger;

        public Instaler(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            _logger.log("We are installing the application");
        }
    }
}