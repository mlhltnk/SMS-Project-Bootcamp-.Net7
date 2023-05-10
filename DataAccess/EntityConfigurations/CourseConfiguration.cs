using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class CourseConfiguration: IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnName("Id").IsRequired();
            builder.Property(u => u.Shortname).HasColumnName("Shortname").IsRequired();
            builder.Property(u => u.Name).HasColumnName("Name").IsRequired();
            builder.Property(u => u.Credit).HasColumnName("Credit").IsRequired();
            builder.Property(u => u.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(u => u.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(u => u.DeletedDate).HasColumnName("DeletedDate");

            builder.HasMany(u => u.CourseStudents);
         
            builder.HasQueryFilter(u => !u.DeletedDate.HasValue);

        }
    }
}
