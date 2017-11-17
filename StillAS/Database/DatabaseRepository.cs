using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database
{
    class DatabaseRepository
    {
        public void CreateModelName(string ModelName)
        {
            var ModelN = new ModelNavn { Modelnavn1 = ModelName };
            var meContext = new stillasEntities();
            meContext.ModelNavns.Add(ModelN);
            meContext.SaveChanges();
        }
    }
}
