using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DataAccess;
using OnlineShop.Domans;
using OnlineShop.DTO;
using OnlineShop.Services;

namespace OnlineShop.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly ISmsService twilioSmsService;
        private readonly OnlineShopContext shopContext;

        public AuthController(IAuthService authService, ISmsService twilioSmsService, OnlineShopContext shopContext)
        {
            this.authService = authService;
            this.twilioSmsService = twilioSmsService;
            this.shopContext = shopContext;
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate(AuthDTO authDTO)
        {
          var responseDTO = await twilioSmsService.SendVerificationCode(authDTO.PhoneNumber);

            if (responseDTO == null)
            {
                return BadRequest("Сообщение не отправлено");
            }

            if(authDTO.Code != responseDTO.VerificationCode)
            {
                return BadRequest("Код введен не верно");
            }
            

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var token = await authService.Authenticate(authDTO.PhoneNumber, authDTO.Code);

            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized();
            }

            return Ok(new { token });
            
            /*
             * +1. Принимаеи объект с данными пользователя DTO 
             * +2. Обращаемся к сервису который проводит аудентификацию
             * +3. Получаем от сервиса токен
             * +  а) Если токе пуст или null - кидаем 401 ошибку
             * +  б) если все нормально то возращаем клиенту токен в объекте
             */
        }
        [HttpGet]
        public async Task<IActionResult> Registration(AuthDTO authDTO)
        {
            var users = shopContext.Users.ToList();
            foreach(var user in users)
            {
                if(user.PhoneNumber == authDTO.PhoneNumber)
                {
                    return BadRequest();
                }
            }
            var responseDTO = await twilioSmsService.SendVerificationCode(authDTO.PhoneNumber);

            if (responseDTO == null)
            {
                return BadRequest("Сообщение не отправлено");
            }

            if (authDTO.Code != responseDTO.VerificationCode)
            {
                return BadRequest("Код введен не верно");
            }
            shopContext.Users.AddRange(new User
            {
                PhoneNumber= authDTO.PhoneNumber,
                VerificationCode = authDTO.Code
            });
            shopContext.SaveChanges();

            return Ok("Пользователь создан");
        }
    }
}