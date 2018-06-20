using System;

namespace Likvido.Credit.Infrastructure.Configuration
{
    class ConfigurationManager : IConfigurationManager
    {
        string IConfigurationManager.GetElasticConnectionString(string clusterName)
        {
            // get values from config
            throw new NotImplementedException();
        }
    }
}
