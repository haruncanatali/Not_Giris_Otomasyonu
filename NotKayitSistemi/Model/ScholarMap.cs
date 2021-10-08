﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotKayitSistemi.Model
{
    public class ScholarMap:EntityTypeConfiguration<Scholar>
    {
        public ScholarMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Tckn).IsRequired().HasMaxLength(11);
            this.Property(c => c.Password).IsRequired().HasMaxLength(8);
            this.Property(c => c.PrivateQuestion).IsRequired().HasMaxLength(150);
            this.Property(c => c.PrivateKey).IsRequired().HasMaxLength(150);

            this.ToTable("Tbl_Scholar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Tckn).HasColumnName("Tckn");
            this.Property(c => c.Password).HasColumnName("Password");
            this.Property(c => c.PrivateQuestion).HasColumnName("PrivateQuestion");
            this.Property(c => c.PrivateKey).HasColumnName("PrivateKey");
        }
    }
}
