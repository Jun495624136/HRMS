using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class BonusConfiger:EntityTypeConfiguration<Bonus>
    {
        public BonusConfiger() 
        {
            this.ToTable(nameof(Bonus));
            this.Property(e=>e.Major_kind_id).HasMaxLength(2);
            this.Property(e => e.Major_id).HasMaxLength(2);
        }
    }
}
