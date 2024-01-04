
using Microsoft.EntityFrameworkCore;
using TalentoTrack.Common.Entities;

using TelentoTrack.Dao.DB;

namespace TalentoTrackDao.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        public TelentoTrack_DbContext _dbContext;
        public AccountRepository(TelentoTrack_DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<LoginDetails> GetLoginDetails(string userName, string passward)
        {
            
            var dbRecord = await _dbContext.tbl_login_details.Where(p => (p.UserName!= null && p.UserName.Equals(userName)) && (p.Passward != null && p.Passward.Equals(passward))).FirstOrDefaultAsync();
            return dbRecord!;
        }
    }
}
