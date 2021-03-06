﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
    public class Config_file_third_kindConfiger : EntityTypeConfiguration<Config_file_third_kind>
    {
        public Config_file_third_kindConfiger() 
        {
            this.ToTable(nameof(Config_file_third_kind));
            this.Property(e=>e.First_kind_id).HasMaxLength(2);
            this.Property(e => e.Second_kind_id).HasMaxLength(2);
            this.Property(e => e.Third_kind_id).HasMaxLength(2);
            this.Property(e => e.Third_kind_is_retail).HasMaxLength(2);
        }
    }
}
