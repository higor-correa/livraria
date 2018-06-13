using AutoMapper;
using Livraria.Domain.Dtos;
using Livraria.Domain.Entities;

namespace Livraria.Domain.AutoMapperProfiles
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<LivroRequestDto, LivroEntity>().ForMember(x => x.Id, opt => opt.Ignore());
            CreateMap<LivroEntity, LivroResponseDto>();
        }
    }
}
