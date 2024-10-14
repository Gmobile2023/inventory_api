using System.Collections.Generic;
using Abp.Dependency;
using Gmobile.Dto;

namespace Gmobile.DataImporting.Excel;

public interface IExcelInvalidEntityExporter<TEntityDto> : ITransientDependency
{
    FileDto ExportToFile(List<TEntityDto> entities);
}