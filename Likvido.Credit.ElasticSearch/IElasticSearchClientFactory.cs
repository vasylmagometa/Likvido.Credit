using Nest;

namespace Likvido.Credit.ElasticSearch
{
    public interface IElasticSearchClientFactory
    {
        IElasticClient GetCompanyElasticClient();

        IElasticClient GetCreditElasticClient();
    }
}
