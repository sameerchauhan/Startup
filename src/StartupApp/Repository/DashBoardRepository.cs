using System.Collections.Generic;
using Domain;

namespace Repository
{
    public class DashBoardRepository : IDashBoardRepository
    {
        private readonly IGenericRepository<DashBoardItem> _genericRepository;

        public DashBoardRepository(IGenericRepository<DashBoardItem> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<DashBoardItem> Get()
        {
            return _genericRepository.Get(null, null, string.Empty);
        }
    }
}