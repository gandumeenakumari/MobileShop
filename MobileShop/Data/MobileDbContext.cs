using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MobileShop.Data
{
    public partial class MobileDbContext : DbContext
    {
        public MobileDbContext()
        {
        }

        public MobileDbContext(DbContextOptions<MobileDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mobile> Mobiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-N5NGH7K\\SQLEXPRESS;Database=MobileDb;Trusted_Connection=True;Integrated Security=True; Encrypt=True;TrustServerCertificate=True;User Instance=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mobile>(entity =>
            {
                entity.Property(e => e.Ram).HasColumnName("RAM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        public List<Mobile> GetMobiles()
        {
            var db = new MobileDbContext();
            return db.Mobiles.ToList();
        }

        public  void PostMobile(Mobile mobile)
        {

            var db = new MobileDbContext();
            db.Mobiles.Add(mobile);
            db.SaveChanges();
        }
        public void DeleteMobile(int MobileId)
        {
            var db = new MobileDbContext();
            Mobile mobile = new Mobile();
            mobile = db.Mobiles.FirstOrDefault(x => x.MobileId == MobileId);
            if (mobile == null)
                throw new Exception("Not Found");
            db.Remove(mobile);
            db.SaveChanges();

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
