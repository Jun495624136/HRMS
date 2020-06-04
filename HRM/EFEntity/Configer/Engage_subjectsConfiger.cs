﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Engage_subjectsConfiger:EntityTypeConfiguration<Engage_subjects>
    {
        public Engage_subjectsConfiger() 
        {
            this.ToTable(nameof(Engage_subjects));
            this.Property(e=>e.First_kind_id).HasMaxLength(2);
            this.Property(e=>e.Second_kind_id).HasMaxLength(2);
        }
    }
}
