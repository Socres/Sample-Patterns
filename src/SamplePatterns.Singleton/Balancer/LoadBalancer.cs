namespace SamplePatterns.Singleton.Balancer
{
    using System;
    using System.Collections.Generic;

    public class LoadBalancer
    {
        private static readonly Lazy<LoadBalancer> LazyLoadBalancer = new Lazy<LoadBalancer>(
            () => new LoadBalancer(),
            true);

        private readonly IList<Server> _servers;
        private readonly Random _random;

        /// <summary>
        /// Instances this instance.
        /// </summary>
        public static LoadBalancer Instance
        {
            get { return LazyLoadBalancer.Value; }
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="LoadBalancer"/> class from being created.
        /// </summary>
        private LoadBalancer()
        {
            _random = new Random();
            _servers = new List<Server> 
                { 
                  new Server{ Name = "ServerI", IP = "120.14.220.18" },
                  new Server{ Name = "ServerII", IP = "120.14.220.19" },
                  new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                  new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                  new Server{ Name = "ServerV", IP = "120.14.220.22" },
                };
        }

        /// <summary>
        /// Gets the next server.
        /// </summary>
        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }

    }
}
