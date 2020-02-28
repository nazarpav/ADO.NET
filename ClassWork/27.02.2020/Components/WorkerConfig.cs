using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCodeFirst.Components
{
    class WorkerConfig : EntityTypeConfiguration<Worker>
    {
        public WorkerConfig()
        {
           this.HasKey(c => c.Id);
           this.HasRequired(c => c.WorkerType).WithMany(b => b.Workers).HasForeignKey(c => c.WorkerTypeId);
        }
    }
}
