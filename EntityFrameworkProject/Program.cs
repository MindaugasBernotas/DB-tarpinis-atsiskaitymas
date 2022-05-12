using System;
using System.Collections.Generic;

namespace EntityFrameworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new DepartamentService();
            service.AddDepartament(new Departament() { Name = "Informatikos" });


            Console.WriteLine("Hello World!");
            
            
            using (var contex = new SchoolContext())
            {
                var student = new Student() { Name = "Irena" };
                var student1 = new Student() { Name = "Laima" };
                
                var departament = new Departament() { Name = "Inžinerijos katerdra" , Students = new List<Student>() { student, student1 } };
                /*var students = new List<Student>() { student1,};*/
/*                departament.Students.AddRange(students);
*/
                contex.Departaments.Add(departament);

                contex.Departaments.Find(17);
                var departamentIK = contex.Departaments.Find(17);
                Console.WriteLine(departamentIK.Name);

               /* contex.Students.Find(4);
                var Students4 = contex.Students.Find(4);
                contex.Students.Remove(Students4);*/


               

                /*                contex.Students.Add(new Student() { Name = "Domas" });
                */
                contex.SaveChanges();
            }
            
        }
    }
}

/*Studentų informacinė sistema:
Entities:
1.Departamentas.Turi: Daug studentų, daug paskaitų.
2. Paskaita. Turi: Daug departamentų.
3. Studentas.Turi: Daug paskaitų, vieną departamentą.
Funkcionalumai:
1. Sukurti departamentą ir į jį pridėti studentus, paskaitas(papildomi points jei pridedamos
paskaitos jau egzistuojančios duomenų bazėje).
2.Pridėti studentus / paskaitas į jau egzistuojantį departamentą.
3. Sukurti paskaitą ir ją priskirti prie departamento.
4. Sukurti studentą, jį pridėti prie egzistuojančio departamento ir priskirti jam egzistuojančias 
paskaitas.
5. Perkelti studentą į kitą departamentą(bonus points jei pakeičiamos ir jo paskaitos).
6. Atvaizduoti visus departamento studentus.
7. Atvaizduoti visas departamento paskaitas.
8. Atvaizduoti visas paskaitas pagal studentą.
*/
