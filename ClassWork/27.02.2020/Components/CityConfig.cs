using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCodeFirst.Components
{
    class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            this.HasKey(c => c.Id);
            this.HasRequired(c => c.Country).WithMany(d => d.Cities).HasForeignKey(c => c.CountryId).WillCascadeOnDelete(true);
        }
    }
}
