using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.DTO;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace OnlineShop.Services
{
    public class TwilioSmsService : ISmsService
    {
        public Task<SmsServiceResponseDTO> SendVerificationCode(string phoneNumber/*, string code*/)
        {

            Random random = new Random();
            string code = random.Next(0, 9999).ToString("D4");
            code = "4444";
            const string accountSid = "ACfdf9f72a415fab9f86b33893394ead7e";
            const string authToken = "e0ffcc69c4a396e15f267cf2bd6b4dc5";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: code + " - This is Verification Code\n"+ DateTime.Now.ToString(),
                from: new Twilio.Types.PhoneNumber("+18562085234"),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );


            return Task.FromResult(new SmsServiceResponseDTO
            {
                StatusCode = 200,
                Message = "Сообщение успешно отправлено",
                VerificationCode = code
            });
        }

       /* public Task<SmsServiceResponseDTO> SendVerificationCode(string phoneNumber, string code)
        {
            throw new NotImplementedException();
        }*/
    }
}
