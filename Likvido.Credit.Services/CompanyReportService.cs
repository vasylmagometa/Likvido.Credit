using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Likvido.Credit.Services.Abstraction;
using Likvido.Credit.DTOs;
using Likvido.Credit.ElasticSearch.Abstraction;

namespace Likvido.Credit.Services
{
    public class CompanyReportService : ICompanyReportService
    {
        private readonly ICompanyReportSearchService companyReportSearchService;

        public CompanyReportService(ICompanyReportSearchService companyReportSearchService)
        {
            this.companyReportSearchService = companyReportSearchService;
        }

        public async Task<List<CompanyReportDTO>> GetCompanyReports(string svrNumber)
        {
            // do some another service related stuff 
            // some code

            // search 
            var result = await this.companyReportSearchService.SearchCompanyReports(svrNumber);

            return result;
        }
    }
}
