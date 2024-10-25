using AspNetStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetStudy.Database
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockOHLCDto>().HasKey(s => new { s.stockNo, s.stockDate });
            /*modelBuilder.Entity<ProductDetail>().HasOne(o => o.discount).WithOne(c => c.productDetail)
       .HasForeignKey<Discount>(o => new { o.companyId, o.productId })
      .HasPrincipalKey<ProductDetail>(o => new { o.companyId, o.productId }).IsRequired(false);*/
            modelBuilder.Entity<StockOHLCDto>().HasData(
                new StockOHLCDto { stockNo = "2303", stockDate  = "23031024"}
                );
        }

        public DbSet<StockOHLCDto> stockOHLCDtos { get; set; }
    }
}
