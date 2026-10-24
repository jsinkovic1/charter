using System;
using System.Collections.Generic;
using Charter___backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Charter___backend.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Fotografija> Fotografijas { get; set; }

    public virtual DbSet<Korisnik> Korisniks { get; set; }

    public virtual DbSet<Luka> Lukas { get; set; }

    public virtual DbSet<Nedostupnitermin> Nedostupnitermins { get; set; }

    public virtual DbSet<Oprema> Opremas { get; set; }

    public virtual DbSet<Plovilo> Plovilos { get; set; }

    public virtual DbSet<Proizvodac> Proizvodacs { get; set; }

    public virtual DbSet<Rezervacija> Rezervacijas { get; set; }

    public virtual DbSet<Termin> Termins { get; set; }

    public virtual DbSet<Tipplovila> Tipplovilas { get; set; }

    public virtual DbSet<Usluga> Uslugas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("btree_gist");

        modelBuilder.Entity<Fotografija>(entity =>
        {
            entity.HasKey(e => e.Idfotografije).HasName("fotografija_pkey");

            entity.ToTable("fotografija");

            entity.Property(e => e.Idfotografije)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idfotografije");
            entity.Property(e => e.Glavnaslika).HasColumnName("glavnaslika");
            entity.Property(e => e.Idplovila).HasColumnName("idplovila");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");

            entity.HasOne(d => d.IdplovilaNavigation).WithMany(p => p.Fotografijas)
                .HasForeignKey(d => d.Idplovila)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fotografija_idplovila_fkey");
        });

        modelBuilder.Entity<Korisnik>(entity =>
        {
            entity.HasKey(e => e.Idkorisnika).HasName("korisnik_pkey");

            entity.ToTable("korisnik");

            entity.HasIndex(e => e.Mail, "korisnik_mail_key").IsUnique();

            entity.HasIndex(e => e.Username, "korisnik_username_key").IsUnique();

            entity.Property(e => e.Idkorisnika)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idkorisnika");
            entity.Property(e => e.Aktivan).HasColumnName("aktivan");
            entity.Property(e => e.Datumrodenja).HasColumnName("datumrodenja");
            entity.Property(e => e.Ime)
                .HasMaxLength(50)
                .HasColumnName("ime");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .HasColumnName("mail");
            entity.Property(e => e.Prezime)
                .HasMaxLength(50)
                .HasColumnName("prezime");
            entity.Property(e => e.Uloga)
                .HasMaxLength(20)
                .HasColumnName("uloga");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Luka>(entity =>
        {
            entity.HasKey(e => e.Idluke).HasName("luka_pkey");

            entity.ToTable("luka");

            entity.Property(e => e.Idluke)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idluke");
            entity.Property(e => e.Latituda)
                .HasPrecision(9, 6)
                .HasColumnName("latituda");
            entity.Property(e => e.Longituda)
                .HasPrecision(9, 6)
                .HasColumnName("longituda");
            entity.Property(e => e.Mjesto)
                .HasMaxLength(100)
                .HasColumnName("mjesto");
            entity.Property(e => e.Nazivluke)
                .HasMaxLength(100)
                .HasColumnName("nazivluke");
        });

        modelBuilder.Entity<Nedostupnitermin>(entity =>
        {
            entity.HasKey(e => e.Idtermina).HasName("nedostupnitermin_pkey");

            entity.ToTable("nedostupnitermin");

            entity.Property(e => e.Idtermina)
                .ValueGeneratedNever()
                .HasColumnName("idtermina");
            entity.Property(e => e.Opis)
                .HasMaxLength(255)
                .HasColumnName("opis");

            entity.HasOne(d => d.IdterminaNavigation).WithOne(p => p.Nedostupnitermin)
                .HasForeignKey<Nedostupnitermin>(d => d.Idtermina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("nedostupnitermin_idtermina_fkey");
        });

        modelBuilder.Entity<Oprema>(entity =>
        {
            entity.HasKey(e => e.Idopreme).HasName("oprema_pkey");

            entity.ToTable("oprema");

            entity.Property(e => e.Idopreme)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idopreme");
            entity.Property(e => e.Cijenanajma)
                .HasPrecision(10, 2)
                .HasColumnName("cijenanajma");
            entity.Property(e => e.Nazivopreme)
                .HasMaxLength(100)
                .HasColumnName("nazivopreme");

            entity.HasMany(d => d.Idterminas).WithMany(p => p.Idopremes)
                .UsingEntity<Dictionary<string, object>>(
                    "Imadodatnuopremu",
                    r => r.HasOne<Rezervacija>().WithMany()
                        .HasForeignKey("Idtermina")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("imadodatnuopremu_idtermina_fkey"),
                    l => l.HasOne<Oprema>().WithMany()
                        .HasForeignKey("Idopreme")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("imadodatnuopremu_idopreme_fkey"),
                    j =>
                    {
                        j.HasKey("Idopreme", "Idtermina").HasName("imadodatnuopremu_pkey");
                        j.ToTable("imadodatnuopremu");
                        j.IndexerProperty<int>("Idopreme").HasColumnName("idopreme");
                        j.IndexerProperty<int>("Idtermina").HasColumnName("idtermina");
                    });
        });

        modelBuilder.Entity<Plovilo>(entity =>
        {
            entity.HasKey(e => e.Idplovila).HasName("plovilo_pkey");

            entity.ToTable("plovilo");

            entity.Property(e => e.Idplovila)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idplovila");
            entity.Property(e => e.Brojkabina).HasColumnName("brojkabina");
            entity.Property(e => e.Brojlezajeva).HasColumnName("brojlezajeva");
            entity.Property(e => e.Dnevnacijenanajma)
                .HasPrecision(10, 2)
                .HasColumnName("dnevnacijenanajma");
            entity.Property(e => e.Godinaproizvodnje).HasColumnName("godinaproizvodnje");
            entity.Property(e => e.Idluke).HasColumnName("idluke");
            entity.Property(e => e.Idproizvodaca).HasColumnName("idproizvodaca");
            entity.Property(e => e.Idtipaplovila).HasColumnName("idtipaplovila");
            entity.Property(e => e.Kapacitet).HasColumnName("kapacitet");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Nazivplovila)
                .HasMaxLength(100)
                .HasColumnName("nazivplovila");

            entity.HasOne(d => d.IdlukeNavigation).WithMany(p => p.Plovilos)
                .HasForeignKey(d => d.Idluke)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plovilo_idluke_fkey");

            entity.HasOne(d => d.IdproizvodacaNavigation).WithMany(p => p.Plovilos)
                .HasForeignKey(d => d.Idproizvodaca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plovilo_idproizvodaca_fkey");

            entity.HasOne(d => d.IdtipaplovilaNavigation).WithMany(p => p.Plovilos)
                .HasForeignKey(d => d.Idtipaplovila)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plovilo_idtipaplovila_fkey");

            entity.HasMany(d => d.Idopremes).WithMany(p => p.Idplovilas)
                .UsingEntity<Dictionary<string, object>>(
                    "Imaopremu",
                    r => r.HasOne<Oprema>().WithMany()
                        .HasForeignKey("Idopreme")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("imaopremu_idopreme_fkey"),
                    l => l.HasOne<Plovilo>().WithMany()
                        .HasForeignKey("Idplovila")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("imaopremu_idplovila_fkey"),
                    j =>
                    {
                        j.HasKey("Idplovila", "Idopreme").HasName("imaopremu_pkey");
                        j.ToTable("imaopremu");
                        j.IndexerProperty<int>("Idplovila").HasColumnName("idplovila");
                        j.IndexerProperty<int>("Idopreme").HasColumnName("idopreme");
                    });
        });

        modelBuilder.Entity<Proizvodac>(entity =>
        {
            entity.HasKey(e => e.Idproizvodaca).HasName("proizvodac_pkey");

            entity.ToTable("proizvodac");

            entity.Property(e => e.Idproizvodaca)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idproizvodaca");
            entity.Property(e => e.Nazivproizvodaca)
                .HasMaxLength(100)
                .HasColumnName("nazivproizvodaca");
        });

        modelBuilder.Entity<Rezervacija>(entity =>
        {
            entity.HasKey(e => e.Idtermina).HasName("rezervacija_pkey");

            entity.ToTable("rezervacija");

            entity.Property(e => e.Idtermina)
                .ValueGeneratedNever()
                .HasColumnName("idtermina");
            entity.Property(e => e.Brojosoba).HasColumnName("brojosoba");
            entity.Property(e => e.Datumkreiranja).HasColumnName("datumkreiranja");
            entity.Property(e => e.Idluke).HasColumnName("idluke");
            entity.Property(e => e.Iznos)
                .HasPrecision(10, 2)
                .HasColumnName("iznos");
            entity.Property(e => e.Poslanaobavijest).HasColumnName("poslanaobavijest");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasColumnName("status");

            entity.HasOne(d => d.IdlukeNavigation).WithMany(p => p.Rezervacijas)
                .HasForeignKey(d => d.Idluke)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rezervacija_idluke_fkey");

            entity.HasOne(d => d.IdterminaNavigation).WithOne(p => p.Rezervacija)
                .HasForeignKey<Rezervacija>(d => d.Idtermina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rezervacija_idtermina_fkey");

            entity.HasMany(d => d.Idkorisnikas).WithMany(p => p.Idterminas)
                .UsingEntity<Dictionary<string, object>>(
                    "KorisnikRezervacija",
                    r => r.HasOne<Korisnik>().WithMany()
                        .HasForeignKey("Idkorisnika")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("korisnik_rezervacija_idkorisnika_fkey"),
                    l => l.HasOne<Rezervacija>().WithMany()
                        .HasForeignKey("Idtermina")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("korisnik_rezervacija_idtermina_fkey"),
                    j =>
                    {
                        j.HasKey("Idtermina", "Idkorisnika").HasName("korisnik_rezervacija_pkey");
                        j.ToTable("korisnik_rezervacija");
                        j.IndexerProperty<int>("Idtermina").HasColumnName("idtermina");
                        j.IndexerProperty<int>("Idkorisnika").HasColumnName("idkorisnika");
                    });
        });

        modelBuilder.Entity<Termin>(entity =>
        {
            entity.HasKey(e => e.Idtermina).HasName("termin_pkey");

            entity.ToTable("termin");

            entity.Property(e => e.Idtermina)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idtermina");
            entity.Property(e => e.Idplovila).HasColumnName("idplovila");
            entity.Property(e => e.Vrijemedo)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("vrijemedo");
            entity.Property(e => e.Vrijemeod)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("vrijemeod");

            entity.HasOne(d => d.IdplovilaNavigation).WithMany(p => p.Termins)
                .HasForeignKey(d => d.Idplovila)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("termin_idplovila_fkey");
        });

        modelBuilder.Entity<Tipplovila>(entity =>
        {
            entity.HasKey(e => e.Idtipaplovila).HasName("tipplovila_pkey");

            entity.ToTable("tipplovila");

            entity.Property(e => e.Idtipaplovila)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idtipaplovila");
            entity.Property(e => e.Nazivtipaplovila)
                .HasMaxLength(50)
                .HasColumnName("nazivtipaplovila");
        });

        modelBuilder.Entity<Usluga>(entity =>
        {
            entity.HasKey(e => e.Idusluge).HasName("usluga_pkey");

            entity.ToTable("usluga");

            entity.Property(e => e.Idusluge)
                .UseIdentityAlwaysColumn()
                .HasColumnName("idusluge");
            entity.Property(e => e.Cijenausluge)
                .HasPrecision(10, 2)
                .HasColumnName("cijenausluge");
            entity.Property(e => e.Nazivusluge)
                .HasMaxLength(100)
                .HasColumnName("nazivusluge");

            entity.HasMany(d => d.Idterminas).WithMany(p => p.Idusluges)
                .UsingEntity<Dictionary<string, object>>(
                    "Imadodatneusluge",
                    r => r.HasOne<Rezervacija>().WithMany()
                        .HasForeignKey("Idtermina")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("imadodatneusluge_idtermina_fkey"),
                    l => l.HasOne<Usluga>().WithMany()
                        .HasForeignKey("Idusluge")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("imadodatneusluge_idusluge_fkey"),
                    j =>
                    {
                        j.HasKey("Idusluge", "Idtermina").HasName("imadodatneusluge_pkey");
                        j.ToTable("imadodatneusluge");
                        j.IndexerProperty<int>("Idusluge").HasColumnName("idusluge");
                        j.IndexerProperty<int>("Idtermina").HasColumnName("idtermina");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
