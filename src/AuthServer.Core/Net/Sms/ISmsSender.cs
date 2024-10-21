using System.Threading.Tasks;

namespace AuthServer.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}