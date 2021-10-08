using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKayitSistemi.Model
{
    public class RequestMap:EntityTypeConfiguration<Request>
    {
        public RequestMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Tckn).IsRequired().HasMaxLength(11);
            this.Property(c => c.Name).IsRequired().HasMaxLength(30);
            this.Property(c => c.Surname).IsRequired().HasMaxLength(30);
            this.Property(c => c.Reason).HasMaxLength(100).IsRequired();
            this.Property(c => c.Description).HasMaxLength(500).IsRequired();

            this.ToTable("Tbl_Request");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Tckn).HasColumnName("Tckn");
            this.Property(c => c.Name).HasColumnName("Name");
            this.Property(c => c.Surname).HasColumnName("Surname");
            this.Property(c => c.Reason).HasColumnName("Reason");
            this.Property(c => c.Description).HasColumnName("Description");
        }
    }
}
