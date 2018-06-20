using Likvido.Credit.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Likvido.Credit.ElasticSearch.Abstraction
{
    public interface ICompanyReportSearchService
    {
        Task<List<CompanyReportDTO>> SearchCompanyReports(string svrNumber);
    }
}
