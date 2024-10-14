using System.Threading.Tasks;

namespace Gmobile.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}