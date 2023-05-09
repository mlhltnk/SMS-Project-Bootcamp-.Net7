using Core.Persistens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate;

public class Instructor:Entity<Guid>
{
    public string Pbik { get; set; }
    public string? NationalityId { get; set; }
    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public DateTime BirthDate { get; set; }
    public bool Status { get; set; }


}
