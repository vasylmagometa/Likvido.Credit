using Likvido.Credit.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Likvido.Credit.Services.Abstraction
{
    public interface ICompanyReportService
    {
        Task<List<CompanyReportDTO>> GetCompanyReports(string svrNumber);
    }
}
