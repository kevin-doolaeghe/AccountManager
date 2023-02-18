using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountManager.Models;

namespace AccountManager.Services {

    public class DatabaseContext : DbContext {

        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base(options) {}

        public DbSet<User> Users { get; set; } = default!;

        public DbSet<Account> Accounts { get; set; } = default!;
        
        public DbSet<Record> Records { get; set; } = default!;
        
        public DbSet<RecordType> RecordTypes { get; set; } = default!;
    }
}
