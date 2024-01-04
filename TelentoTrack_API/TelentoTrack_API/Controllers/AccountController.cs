using Microsoft.AspNetCore.Mvc;
using System;
using TalentoTrackCommon.DTOs.Account;
using TalentoTrackCommon.Services;

namespace TelentoTrack_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;

        public AccountController(ILogger<AccountController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpPost(Name = "Login")]
        public async Task<LoginResponse> Login([FromBody] LoginRequest request)
        {
            var response =await _accountService.VerifyLoginDetails(request);
           
            return response;
        }
    }
}
