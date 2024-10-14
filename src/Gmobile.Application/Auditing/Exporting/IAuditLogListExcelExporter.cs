using System.Collections.Generic;
using Gmobile.Auditing.Dto;
using Gmobile.Dto;

namespace Gmobile.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
