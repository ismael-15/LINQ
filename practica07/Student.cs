using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica07
{
    class Student
    {
        public int idStudent { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }
        public string genero { get; set; }

        public static List<Student> GetStudent()
        {
            List<Student> student = new List<Student>
            {
                new Student { idStudent=1001, firstName="Darlyn", lastName="Luna",age=21, genero="femenino"},
                new Student { idStudent=1002, firstName="Juan", lastName="Vijil",age=21, genero="masculino"},
                new Student { idStudent=1003, firstName="Gabriel", lastName="Salmeron",age=19, genero="masculino"},
                new Student { idStudent=1004, firstName="Antonio", lastName="Hernadez",age=18, genero="masculino"},
                new Student { idStudent=1005, firstName="Sixmy", lastName="Claros",age=18,genero="masculino"},
                new Student { idStudent=1006, firstName="Xenia", lastName="Argueta",age=17,genero="femenino"},
                new Student { idStudent=1007, firstName="Ismael", lastName="Luna",age=19,genero="masculino"},
            };

            //valor de retorno, sera la lista de estuidantes
            return student;
        }
    }
}
