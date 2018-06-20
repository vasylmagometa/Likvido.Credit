using Likvido.Credit.DTOs;
using Likvido.Credit.ElasticSearch.Abstraction;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likvido.Credit.ElasticSearch.Services
{
    class CompanyReportSearchService : ICompanyReportSearchService
    {
        private readonly IElasticClient elasticClient;

        public CompanyReportSearchService(IElasticSearchClientFactory elasticSearchClientFactory)
        {
            elasticClient = elasticSearchClientFactory.GetCompanyElasticClient();
        }

        public async Task<List<CompanyReportDTO>> SearchCompanyReports(string svrNumber)
        {
            var result = await this.elasticClient.SearchAsync<CompanyReportDTO>(s => 
            s.Index("offentligg").AllTypes().Query(
                q => q.MatchPhrasePrefix(ms => ms.Field("svrNumber").Query(svrNumber))));

            return result.Documents.ToList();
        }
    }
}
