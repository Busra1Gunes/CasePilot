using AutoMapper;
using Core;

using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.ApplicationTypeDto;
using Entities.Dto.CaseFileDto;
using Entities.Dto.CaseTypeDto;
using Entities.Dto.DocumentDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using Entities.Dto.KullaniciDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using Entities.Dto.ListDto;
using Entities.Dto.PermissionDto;
using Entities.Dto.RoleDto;
using Entities.Enums;
using Microsoft.AspNetCore.Http;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile(IHttpContextAccessor httpContextAccessor)
        {
            CreateMap<User, UserAddDto>()               
                .ReverseMap();

            CreateMap<User, UserListDto>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(x => x.City.Name))
                .ForMember(dest => dest.District, opt => opt.MapFrom(x => x.District.Name))
				  .ForMember(dest => dest.Role, opt => opt.MapFrom(x => x.Role.Name))
				.ReverseMap();

            CreateMap<CaseFile, CaseFileAddDto>().ReverseMap();

 
            CreateMap<CaseFile, CaseFileDetailDto>()
        .ForMember(dest => dest.CityID, opt => opt.MapFrom(x => x.City.ID))    
        .ForMember(dest => dest.DistrictID, opt => opt.MapFrom(x => x.District.ID))
        .ForMember(dest => dest.CaseTypeID, opt => opt.MapFrom(x => x.CaseType.ID))
        .ForMember(dest => dest.CaseFileShares, opt => opt.MapFrom(x => x.CaseFileShares)) // Güncellendi
        .ForMember(dest => dest.caseFileDefendantListDtos, opt => opt.MapFrom(x => x.CaseFileDefendant))
        .ForMember(dest => dest.applicationTypeID, opt => opt.MapFrom(x => x.ApplicationType.ID))
        .ReverseMap();


         CreateMap<CaseFile, CaseFileListDto>()
        .ForMember(dest => dest.City, opt => opt.MapFrom(x => x.City.Name))
        .ForMember(dest => dest.District, opt => opt.MapFrom(x => x.District.Name))
        .ForMember(dest => dest.CaseType, opt => opt.MapFrom(x => x.CaseType.Name))  
        .ForMember(dest => dest.ApplicationType, opt => opt.MapFrom(x => x.ApplicationType.Name))
        .ReverseMap();

            CreateMap<CaseFileDocument, CaseFileDocumentListDto>()
	   .ForMember(dest => dest.CaseFile, opt => opt.MapFrom(x => x.CaseFile.Name+" "+x.CaseFile.Surname))
	   .ForMember(dest => dest.DocumentType, opt => opt.MapFrom(x => x.DocumentType.Name))
	   .ReverseMap();


			CreateMap<CaseFile, CaseFileUpdateDto>().ReverseMap();
            CreateMap<CaseFileDocument, CaseFileDocumentAddDto>()
                .ReverseMap();

            CreateMap<CaseFileDefendant, CaseFileDefendantAddDto>().ReverseMap();

            CreateMap<CaseFileShare, CaseFileShareDto>()
                .ForMember(dest => dest.ShareUserName, opt => opt.MapFrom(x => x.User.Name + " " + x.User.Surname))
                .ReverseMap();

            CreateMap<CaseFileShare, CaseFileShareAddDto>().ReverseMap();


            CreateMap<CaseFileDefendant, CaseFileDefendantListDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Defendant.Name))
                .ReverseMap();


            CreateMap<CaseType, CaseTypeDto>()            
                .ReverseMap();

            CreateMap<ApplicationType, ApplicationTypeDto>()
              .ReverseMap();


            CreateMap<AccountTransaction, AccountTransactionAddDto>().ReverseMap();

            CreateMap<User, UserAddDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();


            CreateMap<AccountTransaction, AccountTransactionDto>()
            .ForMember(dest => dest.Debtor, opt => opt.MapFrom(x => x.User1.Name+" "+x.User1.Surname))
            .ForMember(dest => dest.Credit, opt => opt.MapFrom(x => x.User2.Name + " " + x.User2.Surname))
            .ForMember(dest => dest.CaseFile, opt => opt.MapFrom(x => x.CaseFile.Name+" "+x.CaseFile.Surname))
           .ForMember(dest => dest.PaymentStatus, opt => opt.MapFrom(x =>
                                         x.PaymentStatus == 1 ? "Ödendi" :
                                         x.PaymentStatus == 2 ? "Ödenmedi" :
                                         x.PaymentStatus == 3 ? "Mahsup Edildi" : "-"
                                                                    ))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(x => x.Type == TransactionType.Fatura ? "Fatura" :
                                                                 x.Type == TransactionType.Kira ? "Kira" :
                                                                 x.Type == TransactionType.Maas ? "Maaş" :
                                                                 x.Type == TransactionType.DosyaMasrafi ? "Dosya Masrafı" :
                                                                 x.Type == TransactionType.Diger ? "Diğer" :
                                                                 x.Type == TransactionType.Transfer ? "Transfer" : "-"))
                                                                 .ReverseMap();

            CreateMap<Defendant, DefendantListDto>().ReverseMap();
            CreateMap<Defendant, DefendantAddDto>().ReverseMap();

            CreateMap<DocumentType, DocumentTypeAddDto>().ReverseMap();
            CreateMap<DocumentType, DocumentTypeListDto>().ReverseMap();

            CreateMap<City, CityListDto>().ReverseMap();
            CreateMap<District, DistrictListDto>().ReverseMap();

            CreateMap<ApplicationType, ApplicationTypeDto>().ReverseMap();


            CreateMap<Role, CreateRoleDto>().ReverseMap();

            CreateMap<Permissions, PermissionAddDto>().ReverseMap();

            CreateMap<RolePermission, RolePermissionAddDto>().ReverseMap();
        }
    }
}
