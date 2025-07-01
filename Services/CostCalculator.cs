using InfraPricingCalculator.Models;

namespace InfraPricingCalculator.Services
{
    public class CostCalculator
    {
        public class ItemCost
        {
            public string Description { get; set; }
            public decimal Cost { get; set; }
        }

        public class CalculationResult
        {
            public List<ItemCost> ItemCosts { get; set; } = new();
            public decimal Total { get; set; }
        }

        public CalculationResult Calculate(ResourceConfig config)
        {
            var result = new CalculationResult();

            foreach (var vm in config.VMs)
            {
                decimal price = vm.VMType == "Standard" ? 100 : 200;
                decimal cost = price * vm.VMCount;
                result.ItemCosts.Add(new ItemCost
                {
                    Description = $"VM {vm.VMType} x{vm.VMCount}",
                    Cost = cost
                });
                result.Total += cost;
            }

            foreach (var db in config.Databases)
            {
                decimal price = db.DatabaseType == "SQL" ? 200 : 150;
                decimal cost = price * db.DatabaseCount;
                result.ItemCosts.Add(new ItemCost
                {
                    Description = $"DB {db.DatabaseType} x{db.DatabaseCount}",
                    Cost = cost
                });
                result.Total += cost;
            }

            foreach (var st in config.Storages)
            {
                decimal price = st.StorageType == "SSD" ? 0.1m : 0.05m;
                decimal cost = price * st.StorageSizeGB;
                result.ItemCosts.Add(new ItemCost
                {
                    Description = $"Disco {st.StorageType} {st.StorageSizeGB}GB",
                    Cost = cost
                });
                result.Total += cost;
            }

            foreach (var fw in config.Firewalls)
            {
                decimal price = fw.FirewallType == "NextGen" ? 300 : 150;
                decimal cost = price * fw.FirewallCount;
                result.ItemCosts.Add(new ItemCost
                {
                    Description = $"Firewall {fw.FirewallType} x{fw.FirewallCount}",
                    Cost = cost
                });
                result.Total += cost;
            }

            foreach (var lb in config.LoadBalancers)
            {
                decimal price = lb.LoadBalancerType == "App" ? 120 : 80;
                decimal cost = price * lb.LoadBalancerCount;
                result.ItemCosts.Add(new ItemCost
                {
                    Description = $"Load Balancer {lb.LoadBalancerType} x{lb.LoadBalancerCount}",
                    Cost = cost
                });
                result.Total += cost;
            }

            foreach (var ip in config.PublicIPs)
            {
                decimal price = 15;
                decimal cost = price * ip.PublicIPCount;
                result.ItemCosts.Add(new ItemCost
                {
                    Description = $"IP Pública x{ip.PublicIPCount}",
                    Cost = cost
                });
                result.Total += cost;
            }

            foreach (var net in config.Networks)
            {
                decimal price = 10;
                decimal cost = price * net.NetworkCount;
                result.ItemCosts.Add(new ItemCost
                {
                    Description = $"Red Virtual x{net.NetworkCount}",
                    Cost = cost
                });
                result.Total += cost;
            }

            if (config.Backup)
            {
                result.ItemCosts.Add(new ItemCost { Description = "Backup", Cost = 50 });
                result.Total += 50;
            }
            if (config.Monitoring)
            {
                result.ItemCosts.Add(new ItemCost { Description = "Monitoreo", Cost = 30 });
                result.Total += 30;
            }

            return result;
        }
    }
}
