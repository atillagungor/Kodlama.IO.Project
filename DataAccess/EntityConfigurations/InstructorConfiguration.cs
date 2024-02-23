using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.ToTable("Instructors").HasKey(i => i.Id);

        builder.Property(i => i.FullName).HasColumnName("FullName").IsRequired();

        builder.HasIndex(u => u.FullName, "UK_Instructors_Name").IsUnique();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
    }
}