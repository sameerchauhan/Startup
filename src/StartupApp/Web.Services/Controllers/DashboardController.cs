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
        private readonly IDashBoardRepository _dashBoardRepository;

        public DashboardController(IDashBoardRepository dashBoardRepository)
        {
            _dashBoardRepository = dashBoardRepository;
            AutoMapper.Mapper.CreateMap<DashBoardItem, DashBoardItemDto>();
        }

        public IEnumerable<DashBoardItemDto> Get()
        {
            return AutoMapper.Mapper.Map<IEnumerable<DashBoardItemDto>>(_dashBoardRepository.Get());
        }
    }
}
