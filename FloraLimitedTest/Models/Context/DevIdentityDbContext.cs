using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FloraLimitedTest.Models.POCO.IdentityCustomization;
using FloraLimitedTest.Modules.Extensions.Context;

namespace FloraLimitedTest.Models.Context {
    public class DevIdentityDbContext : DevDbContext {
        public DevIdentityDbContext()
            : base("name=DefaultConnection") {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<CoreSetting> CoreSettings { get; set; }
        public DbSet<ImageResizeSetting> ImageResizeSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}