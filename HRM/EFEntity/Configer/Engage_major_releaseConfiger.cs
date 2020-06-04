using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Engage_major_releaseConfiger:EntityTypeConfiguration<Engage_major_release>
    {
        public Engage_major_releaseConfiger() 
        {
            this.ToTable(nameof(Engage_major_release));
            this.Property(e => e.First_kind_id).HasMaxLength(2);
            this.Property(e => e.Second_kind_id).HasMaxLength(2);
            this.Property(e => e.Third_kind_id).HasMaxLength(2);
            this.Property(e => e.Major_kind_id).HasMaxLength(2);
            this.Property(e => e.Major_id).HasMaxLength(2);
        }
    }
}
