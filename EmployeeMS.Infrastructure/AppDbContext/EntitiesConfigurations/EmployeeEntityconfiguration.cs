using EmployeeMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Infrastructure.AppDbContext.EntitiesConfigurations
{
    internal class EmployeeEntityconfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName)
                   .IsRequired()
                   .HasMaxLength(100); 
            
            builder.Property(e => e.LastName)
                   .IsRequired()
                   .HasMaxLength(100);
            
            builder.Property(e => e.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(e => e.Salary)
                   .IsRequired();


            builder.Property(e => e.JoinDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasOne(e => e.Department)
                   .WithMany(d => d.Employees)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);   
            
            builder.HasOne(e => e.Profession)
                   .WithMany(d => d.Employees)
                   .HasForeignKey(e => e.ProfessionId)
                   .OnDelete(DeleteBehavior.Restrict);   
        }
    }
}
