namespace SamplePatterns.Singleton
{
    using System;
    using SamplePatterns.Singleton.Balancer;

    class Program
    {
        static void Main(string[] args)
        {
            var b1 = LoadBalancer.Instance;
            var b2 = LoadBalancer.Instance;
            var b3 = LoadBalancer.Instance;
            var b4 = LoadBalancer.Instance;

            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4 &&
                ReferenceEquals(b1, b2) && ReferenceEquals(b2, b3) && ReferenceEquals(b3, b4))
            {
                Console.WriteLine("Same instance\n");
            }

            // Next, load balance 15 requests for a server
            var balancer = LoadBalancer.Instance;
            for (var i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
