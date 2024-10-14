using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gmobile.MultiTenancy.HostDashboard.Dto;

namespace Gmobile.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}