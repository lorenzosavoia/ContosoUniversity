using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        /*
        L'attributo DatabaseGenerated viene illustrato in un'<esercitazione successiva>. 
        Questo attributo consente di immettere l'infrastruttura PK per il corso invece 
        di generare il database.
        */
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
