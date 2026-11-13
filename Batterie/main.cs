namespace Batterie_Sim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var config = new BatterieConfig();
            var battery = new Batterie(config);
            var logger = new CsvLogger(config);
            var dashboard = new ConsoleDashboard();
            var sim = new Simulator(battery, new DailyProfile(config), TimeSpan.Zero, logger,dashboard);

 
            
            sim.Speed = 3600;
            sim.StepSeconds = 600;
            sim.Run(24);
        }
    }
}
