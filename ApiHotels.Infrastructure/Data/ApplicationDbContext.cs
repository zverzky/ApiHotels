using ApiHotels.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApiHotels.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Room> Rooms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Настройка связи Booking - User
        modelBuilder.Entity<Booking>()
            .HasOne(b => b.User) // 
            .WithMany(u => u.Bookings) 
            .HasForeignKey(b => b.UserId);

        // Настройка связи Booking - Hotel
        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Hotel) 
            .WithMany(h => h.Bookings) 
            .HasForeignKey(b => b.HotelId);

        // Настройка связи Room - Hotel
        modelBuilder.Entity<Room>()
            .HasOne(r => r.Hotel) 
            .WithMany(h => h.Rooms) 
            .HasForeignKey(r => r.HotelId);

        // Настройка для User
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.UserName).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Password).IsRequired();
            entity.HasIndex(e => e.Email).IsUnique(); 
        });
    }
}