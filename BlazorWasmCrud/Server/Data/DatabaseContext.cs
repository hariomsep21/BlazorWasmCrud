using BlazorWasmCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWasmCrud.Server.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
    }
}

//"Server=EAT-LTP101;Database=BlazingChat;User ID=sa;Password=password;Encrypt=False;TrustServerCertificate=True;"
