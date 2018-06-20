using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Likvido.Credit.Services.Abstraction;
using Likvido.Credit.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Likvido.Credit.API.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly ICompanyReportService companyReportService;

        public CompanyController(ICompanyReportService companyReportService)
        {
            this.companyReportService = companyReportService;
        }

        [HttpGet]
        public Task<List<CompanyReportDTO>> Reports(string svrNumber)
        {
            return this.companyReportService.GetCompanyReports(svrNumber);
        }
    }
}
