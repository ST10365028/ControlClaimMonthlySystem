using Microsoft.EntityFrameworkCore;

namespace ControlClaimMonthlySystem.Services
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }
    }
}
