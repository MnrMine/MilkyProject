using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.EntityFrameWork
{
    public class EfTeamDal : GenericRepository<Team>, ITeamDal
    {
        public EfTeamDal(MilkyContext context) : base(context)
        {
        }

        public int GetETeamCount()
        {
            var context = new MilkyContext();
            return context.Teams.Count();
        }
    }
}
