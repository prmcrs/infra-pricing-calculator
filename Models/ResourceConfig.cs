namespace InfraPricingCalculator.Models
{
    public class VMItem
    {
        public string VMType { get; set; }
        public int VMCount { get; set; }
    }

    public class DatabaseItem
    {
        public string DatabaseType { get; set; }
        public int DatabaseCount { get; set; }
    }

    public class StorageItem
    {
        public string StorageType { get; set; }
        public int StorageSizeGB { get; set; }
    }

    public class FirewallItem
    {
        public string FirewallType { get; set; }
        public int FirewallCount { get; set; }
    }

    public class LoadBalancerItem
    {
        public string LoadBalancerType { get; set; }
        public int LoadBalancerCount { get; set; }
    }

    public class PublicIPItem
    {
        public int PublicIPCount { get; set; }
    }

    public class NetworkItem
    {
        public int NetworkCount { get; set; }
    }

    public class ResourceConfig
    {
        public List<VMItem> VMs { get; set; } = new();
        public List<DatabaseItem> Databases { get; set; } = new();
        public List<StorageItem> Storages { get; set; } = new();
        public List<FirewallItem> Firewalls { get; set; } = new();
        public List<LoadBalancerItem> LoadBalancers { get; set; } = new();
        public List<PublicIPItem> PublicIPs { get; set; } = new();
        public List<NetworkItem> Networks { get; set; } = new();
        public bool Backup { get; set; }
        public bool Monitoring { get; set; }
    }
}
