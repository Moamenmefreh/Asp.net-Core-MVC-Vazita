using Hayaat_Karima.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

 namespace Hayaat_Karima.Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Pateint> Pateints { get; set; }
    public virtual DbSet<ContactUstb> ContactUstbs { get; set; }
    public DbSet<AppointmentTB> Appointments { get; set; }
    public virtual DbSet<DecentLifeDeserversTb> DecentLifeDeserversTbs { get; set; }

    public virtual DbSet<DoctorsTb> DoctorsTb { get; set; }

    public virtual DbSet<MedicalConstructionTb> MedicalConstructionTbs { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReservationCardTb> ReservationCardTbs { get; set; }

    public virtual DbSet<ReservationTb> ReservationTbs { get; set; }

    public virtual DbSet<SpecializatinTb> SpecializatinTbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-LG1P8DQ\\SQLEXPRESS02;initial catalog=Medical;Integrated Security=SSPI;Trust Server certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<IdentityRole>().HasData(
           new IdentityRole()
           {
               Id = Guid.NewGuid().ToString(),
               Name = "Pateint",
               NormalizedName = "pateint",
               ConcurrencyStamp = Guid.NewGuid().ToString(),
           });
       
        modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.HasNoKey();
        });
        modelBuilder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.HasNoKey();
        });
        modelBuilder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.HasNoKey();
        });
        modelBuilder.Entity<ContactUstb>(entity =>
        {
            entity.Property(e => e.ContactorId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DecentLifeDeserversTb>(entity =>
        {
            entity.HasKey(e => e.DeserversId).HasName("PK_DentelDeserversTB");

            entity.Property(e => e.DeserversId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DoctorsTb>(entity =>
        {
            entity.Property(e => e.DocIdpk).ValueGeneratedNever();
        });

        modelBuilder.Entity<MedicalConstructionTb>(entity =>
        {
            entity.Property(e => e.Mcidpk).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReservationCardTb>(entity =>
        {
            entity.Property(e => e.CardId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReservationTb>(entity =>
        {
            entity.Property(e => e.ResvId).ValueGeneratedNever();
        });

        modelBuilder.Entity<SpecializatinTb>(entity =>
        {
            entity.Property(e => e.SpecializatinIdpk).ValueGeneratedNever();
        });

        base.OnModelCreating(modelBuilder);
    }
}
