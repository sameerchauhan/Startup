using System;
using System.Collections.Generic;
using System.Web.Http;
using Domain;
using Repository;
using Web.Services.Models;

namespace Web.Services.Controllers
{
    public class DashboardController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            AutoMapper.Mapper.CreateMap<DashBoardItem, DashBoardItemDto>();
        }

        public IEnumerable<DashBoardItemDto> Get()
        {
            return AutoMapper.Mapper.Map<IEnumerable<DashBoardItemDto>>(_unitOfWork.DashBoardRepository.Get(null,null,string.Empty));
        }
    }
}
