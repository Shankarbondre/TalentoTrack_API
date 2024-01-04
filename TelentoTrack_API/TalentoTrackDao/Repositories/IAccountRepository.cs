using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.Entities;

namespace TalentoTrackDao.Repositories
{
    public interface IAccountRepository 
    {
        Task<LoginDetails> GetLoginDetails(string userName, string passward);
        
    }
}
