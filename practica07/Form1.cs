using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            dgData.Columns.Add("idStudent", "CODIGO");
            dgData.Columns.Add("firstName", "NOMBRE");
            dgData.Columns.Add("lasName", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("genero", "GENERO");

            foreach(var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firstName, student.lastName, student.age, student.genero);


            }
        }
        private List<Student> selectAllData()
        {
            List<Student> result = (
                                    from student in Student.GetStudent()
                                    select new Student()
                                    {
                                         idStudent = student.idStudent,
                                         firstName = student.firstName,
                                         lastName = student.lastName,
                                         age = student.age,
                                         genero = student.genero
                                    }

                ).ToList();

            return result;


        }
    }
}
