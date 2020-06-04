using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Config_majorConfiger:EntityTypeConfiguration<Config_major>
    {
        public Config_majorConfiger() 
        {
            this.ToTable(nameof(Config_major));
            this.Property(e => e.Major_kind_id).HasMaxLength(2);
            this.Property(e => e.Major_id).HasMaxLength(2);
        }
    }
}
