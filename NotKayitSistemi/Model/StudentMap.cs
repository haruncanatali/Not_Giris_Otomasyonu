using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKayitSistemi.Model
{
    public class StudentMap:EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Tckn).IsRequired().HasMaxLength(11);
            this.Property(c => c.Password).IsRequired().HasMaxLength(8);
            this.Property(c => c.Name).IsRequired().HasMaxLength(30);
            this.Property(c => c.Surname).IsRequired().HasMaxLength(30);
            this.Property(c => c.PrivateQuestion).IsRequired().HasMaxLength(150);
            this.Property(c => c.PrivateKey).IsRequired().HasMaxLength(150);

            this.ToTable("Tbl_Student");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Tckn).HasColumnName("Tckn");
            this.Property(c => c.Password).HasColumnName("Password");
            this.Property(c => c.Name).HasColumnName("Name");
            this.Property(c => c.Surname).HasColumnName("Surname");
            this.Property(c => c.Exam_1).HasColumnName("Exam_1");
            this.Property(c => c.Exam_2).HasColumnName("Exam_2");
            this.Property(c => c.Exam_3).HasColumnName("Exam_3");
            this.Property(c => c.Average).HasColumnName("Average");
            this.Property(c => c.State).HasColumnName("State");
            this.Property(c => c.PrivateQuestion).HasColumnName("PrivateQuestion");
            this.Property(c => c.PrivateKey).HasColumnName("PrivateKey");
        }
    }
}
