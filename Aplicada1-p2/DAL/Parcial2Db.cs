using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Aplicada1_p2.DAL
{
  public   class Parcial2Db : DbContext
    {

        public Parcial2Db() : base("name=ConStr")
        {

        }


    }
}
