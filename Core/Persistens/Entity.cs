using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistens;

public class Entity<TId>:IEntityTimestamps   //generic hale getirdik, yani integerda olabilir stringte yada başka birşeyde
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }       //bu üçüne timestamp,zaman damgası deniyor
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }


    public Entity()
    {
        Id = default; //default değerini ata demek, string defaultu 0 Dır
    }

    public Entity(TId id)
    {
        Id = id;
    }

}





