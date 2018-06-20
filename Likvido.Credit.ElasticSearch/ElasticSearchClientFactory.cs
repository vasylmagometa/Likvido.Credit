using Likvido.Credit.Infrastructure.Configuration;
using Nest;
using System;

namespace Likvido.Credit.ElasticSearch
{
    class ElasticSearchClientFactory : IElasticSearchClientFactory
    {
        private readonly IConfigurationManager configurationManager;

        public ElasticSearchClientFactory(IConfigurationManager configurationManager)
        {
            this.configurationManager = configurationManager;
        }

        public IElasticClient GetCompanyElasticClient()
        {
            return new ElasticClient(new Uri(configurationManager.GetElasticConnectionString("companyCluster")));
        }

        public IElasticClient GetCreditElasticClient()
        {
            return new ElasticClient(new Uri(configurationManager.GetElasticConnectionString("companyCluster")));
        }
    }
}
