namespace Application.Mappings
{
  using AutoMapper;
  using Domain.Account;
  using Domain.Dtos.Account;
  using Domain.Dtos.LeaveRequest;
  using Domain.Enties.Leaves;
  using Domain.Entities;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class MappingProfiles : Profile
  {
    public MappingProfiles()
    {
      CreateMap<Log, GetLogDto>().ReverseMap();
      CreateMap<Message, GetMessageDto>().ReverseMap();
      CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
      CreateMap<ApplicationUser, UserInfoResult>().ReverseMap();

    }
  }
}
