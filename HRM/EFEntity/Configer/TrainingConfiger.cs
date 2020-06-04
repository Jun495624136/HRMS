using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFEntity.Configer
{
   public class TrainingConfiger:EntityTypeConfiguration<Training>
    {
        public TrainingConfiger() 
        {
            this.ToTable(nameof(Training));
            this.Property(e=>e.Major_kind_id).HasMaxLength(2);
            this.Property(e => e.Major_id).HasMaxLength(2);
            this.Property(e => e.Human_id).HasMaxLength(30);
        }
    }
}
