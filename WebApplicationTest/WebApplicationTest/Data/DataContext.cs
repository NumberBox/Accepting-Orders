using WebApplicationTest.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationTest.Data {
    public class DataContext :DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {    
        
        }
        public DbSet<Order> Order { get; set; }
    }
}
