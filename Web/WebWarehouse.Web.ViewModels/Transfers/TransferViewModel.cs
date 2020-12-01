using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using WebWarehouse.Data.Models;
using WebWarehouse.Services.Mapping;

namespace WebWarehouse.Web.ViewModels.Transfers
{
    public class TransferViewModel : IMapFrom<Transfer>, IHaveCustomMappings
    {
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public string OutWarehouse { get; set; }

        public string InWarehouse { get; set; }

        public string UserName { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Transfer, TransferViewModel>().ForMember(
                m => m.OutWarehouse,
                opt => opt.MapFrom(x => x.OutWarehouse.Name));

            configuration.CreateMap<Transfer, TransferViewModel>().ForMember(
                m => m.InWarehouse,
                opt => opt.MapFrom(x => x.InWarehouse.Name));

            configuration.CreateMap<ApplicationUser, TransferViewModel>().ForMember(
                m => m.UserName,
                opt => opt.MapFrom(x => x.FullName));
        }
    }
}
