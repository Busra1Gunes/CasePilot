using AutoMapper;
using Core;

using Entities.Concrete;
using Entities.Dto.AddDto;
using Entities.Dto.ApplicationTypeDto;
using Entities.Dto.CaseFileDto;
using Entities.Dto.CaseTypeDto;
using Entities.Dto.CourtDto;
using Entities.Dto.DocumentDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.HearingDto;
using Entities.Dto.HesapHareketDto;
using Entities.Dto.KullaniciDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using Entities.Dto.ListDto;
using Entities.Dto.PermissionDto;
using Entities.Dto.RoleDto;
using Entities.Dto.UserDto;
using Entities.Enums;
using Microsoft.AspNetCore.Http;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {
        private string GetHearingStatusName(int status)
        {
            return status switch
            {
                1 => "Planlandı",
                2 => "Yapıldı",
                3 => "Ertelendi",
                4 => "İptal Edildi",
                _ => "Bilinmeyen"
            };
        }

        public MapProfile(IHttpContextAccessor httpContextAccessor)
        {
            CreateMap<User, UserAddDto>()               
                .ReverseMap();

            CreateMap<User, UserGetDto>()
               .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City != null ? src.City.Name : null))
               .ForMember(dest => dest.DistrictName, opt => opt.MapFrom(src => src.District != null ? src.District.Name : null))
               .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role != null ? src.Role.Name : null));

            CreateMap<User, UserListDto>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City != null ? src.City.Name : null))
                .ForMember(dest => dest.DistrictName, opt => opt.MapFrom(src => src.District != null ? src.District.Name : null))
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role != null ? src.Role.Name : null));

            // DTO -> User mappings
            CreateMap<UserAddDto, User>()
                .ForMember(dest => dest.ID, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.DeletedDate, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.Ignore())
                .ForMember(dest => dest.City, opt => opt.Ignore())
                .ForMember(dest => dest.District, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.CaseFileShares, opt => opt.Ignore())
                .ForMember(dest => dest.HesapHareket1, opt => opt.Ignore())
                .ForMember(dest => dest.HesapHareket2, opt => opt.Ignore());

            CreateMap<UserRegisterDto, User>()
                .ForMember(dest => dest.ID, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.DeletedDate, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.Ignore())
                .ForMember(dest => dest.City, opt => opt.Ignore())
                .ForMember(dest => dest.District, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.CaseFileShares, opt => opt.Ignore())
                .ForMember(dest => dest.HesapHareket1, opt => opt.Ignore())
                .ForMember(dest => dest.HesapHareket2, opt => opt.Ignore());

            CreateMap<UserUpdateDto, User>()
                .ForMember(dest => dest.ID, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.DeletedDate, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.Ignore())
                .ForMember(dest => dest.City, opt => opt.Ignore())
                .ForMember(dest => dest.District, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.CaseFileShares, opt => opt.Ignore())
                .ForMember(dest => dest.HesapHareket1, opt => opt.Ignore())
                .ForMember(dest => dest.HesapHareket2, opt => opt.Ignore())
                .ForMember(dest => dest.Password, opt => opt.Ignore()); // Şifre ayrıca işleniyor

            CreateMap<UserProfileUpdateDto, User>()
                .ForMember(dest => dest.ID, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.DeletedDate, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.Ignore())
                .ForMember(dest => dest.Mail, opt => opt.Ignore()) // Email değiştirilemez
                .ForMember(dest => dest.Password, opt => opt.Ignore()) // Şifre ayrı endpoint
                .ForMember(dest => dest.RoleID, opt => opt.Ignore()) // Role değiştirilemez
                .ForMember(dest => dest.City, opt => opt.Ignore())
                .ForMember(dest => dest.District, opt => opt.Ignore())
                .ForMember(dest => dest.Role, opt => opt.Ignore())
                .ForMember(dest => dest.CaseFileShares, opt => opt.Ignore())
                .ForMember(dest => dest.HesapHareket1, opt => opt.Ignore())
                .ForMember(dest => dest.HesapHareket2, opt => opt.Ignore());

            // Cross-DTO mappings
            CreateMap<UserRegisterDto, UserAddDto>()
                .ForMember(dest => dest.RoleID, opt => opt.MapFrom(src => 2)); // Default User role

            // Reverse mappings
            CreateMap<User, UserAddDto>()
                .ForMember(dest => dest.Password, opt => opt.Ignore()); // Şifre döndürülmez

            CreateMap<User, UserUpdateDto>()
                .ForMember(dest => dest.Password, opt => opt.Ignore()); // Şifre döndürülmez

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
        .ForMember(dest => dest.CaseStatus, opt => opt.MapFrom(x =>
                      x.CaseStatus == 1 ? "Açık" :
                      x.CaseStatus == 2 ? "Kapalı" :
                      x.CaseStatus == 3 ? "İptal Edildi" : "Bilinmiyor"))
        .ForMember(dest => dest.Defendants,  opt => opt.MapFrom(x => string.Join(" - ",x.CaseFileDefendant.Select(d => d.Defendant.Name))))
        .ForMember(dest => dest.Shares, opt => opt.MapFrom(x => string.Join(" - ", x.CaseFileShares.Select(d => d.User.Name+" "+d.User.Surname))))
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
                .ForMember(dest => dest.CaseFileName, opt => opt.MapFrom(x => x.CaseFile.Name + " " + x.CaseFile.Surname))
                .ReverseMap();

            CreateMap<CaseFileShare, CaseFileShareAddDto>().ReverseMap();


            CreateMap<CaseFileDefendant, CaseFileDefendantListDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Defendant.Name))
                .ReverseMap();


            CreateMap<CaseType, CaseTypeDto>()            
                .ReverseMap();

            CreateMap<CaseType, CaseTypeAddDto>()
             .ReverseMap();

            CreateMap<ApplicationType, ApplicationTypeDto>()
              .ReverseMap();

            CreateMap<ApplicationType, ApplicationTypeAddDto>()
             .ReverseMap();

            CreateMap<AccountTransaction, AccountTransactionAddDto>().ReverseMap();

        
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

            CreateMap<CaseFileNote, CaseFileNoteListDto>()
                 .ForMember(dest => dest.User, opt => opt.MapFrom(x => x.User.Name + " " + x.User.Surname))
                 .ForMember(dest => dest.CaseFile, opt => opt.MapFrom(x => x.CaseFile.Name + " " + x.CaseFile.Surname))
                 .ReverseMap();

            CreateMap<CaseFileNote, CaseFileNoteAddDto>().ReverseMap();

            CreateMap<CourtAddDto, Court>();
            CreateMap<CourtUpdateDto, Court>();

            CreateMap<Court, CourtListDto>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name))
                .ForMember(dest => dest.DistrictName, opt => opt.MapFrom(src => src.District.Name));

            CreateMap<Court, CourtDetailDto>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City.Name))
                .ForMember(dest => dest.DistrictName, opt => opt.MapFrom(src => src.District.Name))
                .ForMember(dest => dest.Hearings, opt => opt.MapFrom(src => src.Hearings));

            CreateMap<HearingAddDto, Hearing>();
            CreateMap<HearingUpdateDto, Hearing>();

            CreateMap<Hearing, HearingListDto>()
                .ForMember(dest => dest.CaseFileName, opt => opt.MapFrom(src => src.CaseFile.Name + " " + src.CaseFile.Surname))
                .ForMember(dest => dest.CourtName, opt => opt.MapFrom(src => src.Court.Name))
                .ForMember(dest => dest.HearingStatusName, opt => opt.MapFrom(src => GetHearingStatusName(src.HearingStatus)));

            CreateMap<Hearing, HearingDetailDto>()
                .ForMember(dest => dest.CaseFileName, opt => opt.MapFrom(src => src.CaseFile.Name + " " + src.CaseFile.Surname))
                .ForMember(dest => dest.CaseFileNumber, opt => opt.MapFrom(src => src.CaseFile.ID.ToString()))
                .ForMember(dest => dest.CourtName, opt => opt.MapFrom(src => src.Court.Name))
                .ForMember(dest => dest.CourtAddress, opt => opt.MapFrom(src => src.Court.Address))
                .ForMember(dest => dest.HearingStatusName, opt => opt.MapFrom(src => GetHearingStatusName(src.HearingStatus)));


        }
    }
}
