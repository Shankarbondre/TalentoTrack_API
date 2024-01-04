using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrackCommon.DTOs.Account;

namespace TalentoTrackCommon.Services
{
    public interface IAccountService
    {
        Task<LoginResponse> VerifyLoginDetails(LoginRequest request);
       
    }

}
