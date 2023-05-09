using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistens;

public class IEntityTimestamps
{
   public DateTime CreatedDate { get; set; }       //bu üçüne timestamp,zaman damgası deniyor
   public DateTime? UpdatedDate { get; set; }
   public DateTime? DeletedDate { get; set; }
}
