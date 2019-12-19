using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domans;
using OnlineShop.DTO;

namespace OnlineShop.Services
{
    public interface IPaymentService
    {
        Task<PaymentServiceResponseDTO> CreateInvoice(Order order);

    }
}
