using SoteriaProjectWebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoteriaApp.Services.Interfaces
{
    public interface IReportService
    {
        Task<Report> CreateReport (Report report);
    }
}
