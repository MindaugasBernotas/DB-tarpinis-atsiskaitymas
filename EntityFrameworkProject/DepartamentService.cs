using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    internal class DepartamentService
    {
        public void AddDepartament (Departament departamentas)
        // The parameter x is passed by value.
        // Changes to x will not affect the original value of x.
        {
            using (var contex = new SchoolContext())
            {
                contex.Departaments.Add(departamentas);
                contex.SaveChanges();
            }
                
            
        }



     /*   contex.Departaments.Find(17);
                var departamentIK = contex.Departaments.Find(17);
        Console.WriteLine(departamentIK.Name);*/




        // I just got executed!
        // I just got executed!
        // I just got executed!
    }
}
