using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Engage_examConfiger:EntityTypeConfiguration<Engage_exam>
    {
        public Engage_examConfiger() 
        {
            this.ToTable(nameof(Engage_exam));
            this.Property(e=>e.Major_id).HasMaxLength(2);
            this.Property(e => e.Major_kind_id).HasMaxLength(2);
        }
    }
}
