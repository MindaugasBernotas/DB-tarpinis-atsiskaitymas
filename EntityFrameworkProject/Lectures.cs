using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    internal class Lectures
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Departament> Departments { get; set; } = new List<Departament>();

    }
}

