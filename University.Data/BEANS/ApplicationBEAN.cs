using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data.BEANS
{
    public class ApplicationBEAN
    {
        public int ApplicationId { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantAddress { get; set; }
        public string ApplicantPhone { get; set; }
        public string ApplicantEmail { get; set; }
        public string CourseName { get; set; }
        public string University { get; set; }
        public string PersonalStatement { get; set; }
        public string TeacherReference { get; set; }
        public string TeacherContactDetails { get; set; }
        public string UniversityOffer { get; set; }
        public Nullable<bool> Firm { get; set; }
    }
}
