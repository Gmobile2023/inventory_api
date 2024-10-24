using System.Threading.Tasks;

namespace Inventory.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}