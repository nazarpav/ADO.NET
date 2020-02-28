using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCodeFirst.Components
{
    class DirectorConfig :EntityTypeConfiguration<Director>
    {
        public DirectorConfig()
        {
            this.Ignore(a => a.FullName);
            this.Property(c => c.Phone).IsRequired();
            this.Property(c => c.Education).IsOptional();
        }
    }
}
