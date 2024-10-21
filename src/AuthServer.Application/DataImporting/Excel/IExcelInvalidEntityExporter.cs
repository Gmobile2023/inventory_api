using System.Collections.Generic;
using Abp.Dependency;
using AuthServer.Dto;

namespace AuthServer.DataImporting.Excel;

public interface IExcelInvalidEntityExporter<TEntityDto> : ITransientDependency
{
    FileDto ExportToFile(List<TEntityDto> entities);
}