using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Engage_resumeConfiger:EntityTypeConfiguration<Engage_resume>
    {
        public Engage_resumeConfiger() 
        {
            this.ToTable(nameof(Engage_resume));
            this.Property(e=>e.Human_major_kind_id).HasMaxLength(2);
            this.Property(e => e.Human_major_id).HasMaxLength(2);
            this.Property(e => e.Human_sex).HasMaxLength(2);
           
        }
    }
}
