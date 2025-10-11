using EmployeeMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EmployeeMS.Infrastructure.AppDbContext.EntitiesConfigurations
{
    public class ProfessionEntityConfiguration : IEntityTypeConfiguration<Profession>
    {
      
        public void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Description)
                   .IsRequired()
                   .HasMaxLength(300);

            builder.Property(p => p.AcceptedSalary)
                   .IsRequired();

            builder.HasMany(p => p.Employees)
                   .WithOne(e => e.Profession)
                   .HasForeignKey(e => e.Profession)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
    
}
