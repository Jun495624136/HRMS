using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Config_primary_keyConfiger:EntityTypeConfiguration<Config_primary_key>
    {
        public Config_primary_keyConfiger() 
        {
            this.ToTable(nameof(Config_primary_key));
        }
    }
}
