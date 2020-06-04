using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Config_public_charConfiger:EntityTypeConfiguration<Config_public_char>
    {
        public Config_public_charConfiger() 
        {
            this.ToTable(nameof(Config_public_char));
        }
    }
}
