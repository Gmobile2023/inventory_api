using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthServer.MultiTenancy.HostDashboard.Dto;

namespace AuthServer.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}