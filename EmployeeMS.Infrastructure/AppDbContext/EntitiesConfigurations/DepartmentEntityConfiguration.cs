using EmployeeMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeMS.Infrastructure.AppDbContext.EntitiesConfigurations
{
    internal class DepartmentEntityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(100);
            
            builder.Property(d => d.Description)
                   .IsRequired()
                   .HasMaxLength(300);

            builder.Property(d => d.CreationDate)
                 .HasColumnType("date")
                 .IsRequired();

            builder.HasMany(d => d.Employees)
                   .WithOne(e => e.Department)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
