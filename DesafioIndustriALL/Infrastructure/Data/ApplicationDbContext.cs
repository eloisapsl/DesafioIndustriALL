using DesafioIndustriALL.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioIndustriALL.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> User { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Approval> ApprovalSteps { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PurchaseOrder → User (criado por)
            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(o => o.CreatedBy)
                .WithMany()
                .HasForeignKey("CreatedByUserId")
                .OnDelete(DeleteBehavior.Restrict);

            // PurchaseOrder → OrderItems (contém)
            modelBuilder.Entity<OrderItem>()
                .HasOne<PurchaseOrder>()
                .WithMany(o => o.Items)
                .HasForeignKey(i => i.PurchaseOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // PurchaseOrder → Approvals (possui)
            modelBuilder.Entity<Approval>()
                .HasOne<PurchaseOrder>()
                .WithMany(o => o.Approvals)
                .HasForeignKey(a => a.PurchaseOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Approval → User (aprovado por, nullable)
            modelBuilder.Entity<Approval>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(a => a.ApprovedByUserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            // PurchaseOrder → OrderHistory (registra)
            modelBuilder.Entity<OrderHistory>()
                .HasOne<PurchaseOrder>()
                .WithMany(o => o.History)
                .HasForeignKey(h => h.PurchaseOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // OrderHistory → User (realizado por, nullable)
            modelBuilder.Entity<OrderHistory>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(h => h.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
        }
    }
