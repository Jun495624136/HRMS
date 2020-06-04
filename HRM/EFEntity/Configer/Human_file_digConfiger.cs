using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class Human_file_digConfiger:EntityTypeConfiguration<Human_file_dig>
    {
        public Human_file_digConfiger() 
        {
            this.ToTable(nameof(Human_file_dig));
            this.Property(e=>e.First_kind_id).HasMaxLength(2);
            this.Property(e => e.Third_kind_id).HasMaxLength(2);
            this.Property(e => e.Second_kind_id).HasMaxLength(2);
            this.Property(e => e.Human_major_kind_id).HasMaxLength(2);
            this.Property(e => e.Human_major_id).HasMaxLength(2);
            this.Property(e => e.Human_sex).HasMaxLength(2);
        }
    }
}
