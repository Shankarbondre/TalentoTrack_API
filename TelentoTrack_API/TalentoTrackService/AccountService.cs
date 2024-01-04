
using TalentoTrackCommon.DTOs.Account;
using TalentoTrackCommon.Services;
using TalentoTrackDao.Repositories;

namespace TalentoTrackService
{
    public class AccountService : IAccountService
    {
        public readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
           _accountRepository = accountRepository;
        }
    
        public async Task<LoginResponse> VerifyLoginDetails(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            try
            {
                var dbUser = await _accountRepository.GetLoginDetails(request.UserName!, request.Passward!);
                if (dbUser == null)
                {
                    response.Success = true;
                    response.ErrorMessage = "Invalid Credentials";

                }
                else
                {
                    response.Success = true;
                }

                return response;
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        
    }
}
