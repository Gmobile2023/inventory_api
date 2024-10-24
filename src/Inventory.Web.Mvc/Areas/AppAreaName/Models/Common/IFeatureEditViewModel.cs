using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Inventory.Editions.Dto;

namespace Inventory.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}