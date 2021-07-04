using miniPrpject_Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;

namespace miniPrpject_Asp.Services
{
    public class CoursService : ICoursService
    {

        private ApplicationDbContext _context;

        public CoursService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCours(Cours cours)
        {
            _context.Cours.Add(cours);
            _context.SaveChanges();
        }

        public void DeleteCours(int id)
        {
            throw new NotImplementedException();
        }

        public List<CoursService> GetAllLocals()
        {
            throw new NotImplementedException();
        }

        public void UpdateCours(CoursService newCours)
        {
            throw new NotImplementedException();
        }
    }
}
