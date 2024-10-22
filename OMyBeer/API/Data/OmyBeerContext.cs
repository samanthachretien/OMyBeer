using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public partial class OmyBeerContext : DbContext
{
    public OmyBeerContext()
    {
    }

    public OmyBeerContext(DbContextOptions<OmyBeerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TBeer> TBeers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=OMyBeer;User Id=sa;Password=Omybeer!1234;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TBeer>(entity =>
        {
            entity.ToTable("T_BEER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .HasColumnName("NOM");
            entity.Property(e => e.Volume)
                .HasMaxLength(5)
                .HasColumnName("VOLUME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
