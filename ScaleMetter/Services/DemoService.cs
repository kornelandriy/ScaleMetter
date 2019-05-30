using System;
using System.Threading;
using System.Threading.Tasks;

namespace ScaleMetter.Services
{
    public class DemoService : BackgroundService
    {
        public DemoService()
        {
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Demo Service is starting");
            stoppingToken.Register(() => Console.WriteLine("Demo Service is stopping(by token)"));
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine("Demo Service is running in background");
                await Task.Delay(5000, stoppingToken);
            }
            Console.WriteLine("Demo service is stopping");
        }
    }
}