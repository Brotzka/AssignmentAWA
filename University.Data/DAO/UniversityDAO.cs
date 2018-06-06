using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data.DAO
{
    public class UniversityDAO : IDAO.IUniversityDAO
    {
        private UniversityEntities _context;

        public UniversityDAO()
        {
            _context = new UniversityEntities();
        }

        public IList<University> GetUniversities()
        {
            IQueryable<University> _university;
            _university = from university
                         in _context.University
                         select university;

            return _university.ToList<University>();
        }

        
    }
}
