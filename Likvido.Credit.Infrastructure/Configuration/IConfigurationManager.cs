namespace Likvido.Credit.Infrastructure.Configuration
{
    public interface IConfigurationManager
    {
        string GetElasticConnectionString(string clusterName);
    }
}
