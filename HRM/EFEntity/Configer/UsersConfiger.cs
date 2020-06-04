using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configer
{
   public class UsersConfiger:EntityTypeConfiguration<Users>
    {
        public UsersConfiger()
        {
            this.ToTable(nameof(Users));
            this.Property(e => e.U_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.U_password).HasMaxLength(60).IsRequired();
            this.Property(e => e.U_true_name).HasMaxLength(60).IsRequired();
        }

	}
}
