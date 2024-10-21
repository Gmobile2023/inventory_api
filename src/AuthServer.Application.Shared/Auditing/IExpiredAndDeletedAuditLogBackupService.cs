using System.Collections.Generic;
using Abp.Auditing;

namespace AuthServer.Auditing
{
    public interface IExpiredAndDeletedAuditLogBackupService
    {
        bool CanBackup();
        
        void Backup(List<AuditLog> auditLogs);
    }
}