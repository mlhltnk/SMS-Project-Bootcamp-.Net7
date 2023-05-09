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
            builder.ToTable("Courses").HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Shortname).HasColumnName("Shortname").IsRequired();
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired();
            builder.Property(t => t.Credit).HasColumnName("Credit").IsRequired();
            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

            builder.HasMany(t => t.CourseStudents);

         
            builder.HasQueryFilter(t => !t.DeletedDate.HasValue);

        }
    }
}
