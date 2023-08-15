using GalloTube.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GalloTube.Data;
public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Tag> Tags { get; set;}
    public DbSet<Video> Video { get; set; }
    public DbSet<VideoTag> VideoComments { get; set; } 

    protected override void OnModelCreating(ModelBuilder builder) //void não tem retorno
    {
        base.OnModelCreating(builder);
        AppDbSeed appDbSeed = new(builder);

        //FluentAPI
        #region Personalização do Identity
        builder.Entity<IdentityUser>(b => {
            b.ToTable("Users");
        });
        builder.Entity<IdentityUserClaim<string>>(b => {
            b.ToTable("UserClaims");
        });
        builder.Entity<IdentityUserLogin<string>>(b => {
            b.ToTable("UserLogins");
        });
        builder.Entity<IdentityUserToken<string>>(b => {
            b.ToTable("UserTokens");
        });
        builder.Entity<IdentityRole>(b => {
            b.ToTable("Roles");
        });
        builder.Entity<IdentityRoleClaim<string>>(b => {
            b.ToTable("RoleClaims");
        });
        builder.Entity<IdentityUserRole<string>>(b => {
            b.ToTable("UserRoles");
        });
        #endregion

        #region Many To Many - VideoTag
        // Definição de Chave Primária Composta
        builder.Entity<VideoTag>().HasKey(
            vt => new { vt.VideoId, vt.TagId }
        );

        builder.Entity<VideoTag>()
            .HasOne(vt => vt.Video)
            .WithMany(t => t.Tag)
            .HasForeignKey(vt => vt.VideoId);

        builder.Entity<VideoTag>()
            .HasOne(vt => vt.Tag)
            .WithMany(v => v.Video)
            .HasForeignKey(vt => vt.TagId);
        #endregion
    }
}