using miniPrpject_Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniPrpject_Asp.Services
{
    interface ICoursService
    {

        List<CoursService> GetAllLocals();
        void AddCours(Cours cours);
        void UpdateCours(CoursService newCours);
        void DeleteCours(int id);
       
    }
}
