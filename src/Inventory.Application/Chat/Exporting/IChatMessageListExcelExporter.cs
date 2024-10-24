using System.Collections.Generic;
using Abp;
using Inventory.Chat.Dto;
using Inventory.Dto;

namespace Inventory.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
