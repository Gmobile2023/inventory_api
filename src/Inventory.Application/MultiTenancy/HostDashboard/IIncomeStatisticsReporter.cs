﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.MultiTenancy.HostDashboard.Dto;

namespace Inventory.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}