using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Config_major_kindConfiger:EntityTypeConfiguration<Config_major_kind>
    {
        public Config_major_kindConfiger() 
        {
            this.ToTable(nameof(Config_major_kind));
            this.Property(e=>e.Major_kind_id).HasMaxLength(2);
        }
    }
}
