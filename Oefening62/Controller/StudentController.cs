using Oefening62.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht62.Controller
{
    class StudentController
    {
        // Dit is het object waar de Studenten daadwerkelijk opgeslagen worden
        private List<StudentModel> studentList = new List<StudentModel>();

        // Constructor, waarin dummy data aangemaakt wordt
        public StudentController()
        {
            StudentModel student1 = new StudentModel { StudentName = "Kimi Brouwers", StudentNumber = 15151, StudentClassCode = "IO2A4", StudentTelephone = "+735116462" };
            StudentModel student2 = new StudentModel { StudentName = "Kees Verstappen", StudentNumber = 50023535, StudentClassCode = "IO2B4", StudentTelephone = "+638715841" };
            StudentModel student3 = new StudentModel { StudentName = "Max Hamilton", StudentNumber = 50023549, StudentClassCode = "IO2C4", StudentTelephone = "+644847477" };

            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
        }

        /// <summary>
        /// Voeg een StudentModel aan de database toe
        /// </summary>
        /// <param name="StudentModel"></param>
        /// <returns>Het aantal rows affected</returns>
        public int Create(StudentModel StudentModel)
        {
            studentList.Add(StudentModel);
            return 1;
        }

        /// <summary>
        /// Lees alle StudentenBO's uit de database uit
        /// </summary>
        /// <returns>De List met alle StudentModel objecten</returns>
        public List<StudentModel> Read()
        {
            return studentList;
        }

        /// <summary>
        /// Update een bestaande StudentModel in de database
        /// </summary>
        /// <param name="StudentModel"></param>
        /// <returns>Het aantal rows affected</returns>
        public int Update(StudentModel StudentModel)
        {
            int index = studentList.FindIndex(s => s.StudentName == StudentModel.StudentName);

            if (index != 0)
            {
                // Record gevonden, dus doe een update
                studentList[index] = StudentModel;
                return 1;
            }
            else
            {
                // Geen record gevonden, dus doe niets
                return 0;
            }
        }


        /// <summary>
        ///  Verwijder de gegeven StudentModel uit de database
        /// </summary>
        /// <param name="StudentModel"></param>
        /// <returns>Het aantal rows affected</returns>
        public int Delete(StudentModel StudentModel)
        {
            bool result = studentList.Remove(StudentModel);

            if (result == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
