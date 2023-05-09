using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.ToTable("Instructor").HasKey(t => t.Id);
        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(t => t.Pbik).HasColumnName("Pbik").IsRequired();
        builder.Property(t => t.NationalityId).HasColumnName("NationalityId");
        builder.Property(t => t.Firstname).HasColumnName("Firstname").IsRequired();
        builder.Property(t => t.Lastname).HasColumnName("Lastname").IsRequired();
        builder.Property(t => t.BirthDate).HasColumnName("BirthDate").IsRequired();
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(t => t.Status).HasColumnName("Status").IsRequired();

        
        builder.HasQueryFilter(t=>!t.DeletedDate.HasValue);

    }
}
