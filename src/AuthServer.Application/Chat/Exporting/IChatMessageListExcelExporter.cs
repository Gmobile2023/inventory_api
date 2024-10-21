using System.Collections.Generic;
using Abp;
using AuthServer.Chat.Dto;
using AuthServer.Dto;

namespace AuthServer.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
