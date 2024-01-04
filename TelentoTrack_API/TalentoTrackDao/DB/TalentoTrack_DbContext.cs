using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelentoTrack.Common.Entities;

namespace TelentoTrack.Dao.DB
{
    public class TelentoTrack_DbContext:DbContext
    {
        public DbSet<User> tbl_user { get; set; }

        public DbSet<TalentoTrack.Common.Entities.LoginDetails> tbl_login_details { get; set; }
        public TelentoTrack_DbContext(DbContextOptions<TelentoTrack_DbContext> options) : base(options) { }
    }
}
