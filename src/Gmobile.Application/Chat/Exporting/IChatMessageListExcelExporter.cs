using System.Collections.Generic;
using Abp;
using Gmobile.Chat.Dto;
using Gmobile.Dto;

namespace Gmobile.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
