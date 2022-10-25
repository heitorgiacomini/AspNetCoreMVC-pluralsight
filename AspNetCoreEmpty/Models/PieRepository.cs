using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEmpty.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> Pies
        {
            get
            {
                return _appDbContext.Pie.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDbContext.Pie.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }
        public Pie GetPieById(int pieId)
        {
            //return _appDbContext.Pie.Include(c => c.Category).FirstOrDefault(p => p.PieId == pieId);
            return _appDbContext.Pie.FirstOrDefault(p => p.PieId == pieId);
        }

        public void CreatePie(Pie pie)
        {
            throw new NotImplementedException();
        }


        public void UpdatePie(Pie pie)
        {
            throw new NotImplementedException();
        }
    }
}
