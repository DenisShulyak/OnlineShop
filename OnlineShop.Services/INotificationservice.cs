using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public interface INotificationservice
    {
        Task SendInformMessage(List<string> ids, string message);
    }
}
