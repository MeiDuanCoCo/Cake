using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Cake.Domain.Link;

namespace Cake.Domain
{
    /// <summary>
    ///     数据库上下文
    /// </summary>
    public class CakeContext : DbContext
    {
        public CakeContext()
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public CakeContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<QuickLink> QuickLinks { get; set; }
        public virtual DbSet<QuickLinkItem> QuickLinkItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // 移除复数表名的契约
        }
    }
}