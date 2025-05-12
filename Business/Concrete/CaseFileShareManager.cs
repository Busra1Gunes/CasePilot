using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.CaseFileDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CaseFileShareManager : ICaseFileShareService
    {
        IMapper _mapper;
        ICaseFileShareDal _caseFileShareDal;
        IUnitOfWork _unitOfWork;
        public CaseFileShareManager(IMapper mapper, ICaseFileShareDal caseFileShareDal, IUnitOfWork unitOfWork)
        {
            _caseFileShareDal = caseFileShareDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IResult> Add(CaseFileShareAddDto caseFileShareAddDto)
        {
            CaseFileShare? caseFileShareAdd = _mapper.Map<CaseFileShareAddDto, CaseFileShare>(caseFileShareAddDto);
            await _caseFileShareDal.AddAsync(caseFileShareAdd);
            return new SuccessResult(CommonMessages.EntityAdded);
        }

        public Task<IDataResult<CaseFileShareDto>> Get(int shareID)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<CaseFileShareListDto>> GetAll()
        {
            var shares = _caseFileShareDal
                 .Where(x => x.Status == false)
                 .Include(a => a.CaseFile)
                 .Include(a => a.User);

            var totalDto = new CaseFileShareTotalDto();

            foreach (var h in shares)
            {
                if (h.ShareRate != null)
                    totalDto.TotalShareRate += h.ShareRate;
            }

            CaseFileShareListDto caseFileShareListDto = new()
            {
                Total = totalDto,
                ShareDto = _mapper.Map<List<CaseFileShareDto>>(shares)
            };
            return new SuccessDataResult<CaseFileShareListDto>(caseFileShareListDto,CommonMessages.EntityListed);
        }

        public async Task<IDataResult<CaseFileShareListDto>> GetAllByCaseFileID(int caseFileID)
        {
            var shares = _caseFileShareDal
                 .Where(x => x.Status == false && x.CaseFileID == caseFileID)
                 .Include(a => a.CaseFile)
                 .Include(a => a.User);

            var totalDto = new CaseFileShareTotalDto();

            foreach (var h in shares)
            {
                if (h.ShareRate != null)
                    totalDto.TotalShareRate += h.ShareRate;
            }


            CaseFileShareListDto caseFileShareListDto = new()
            {
                Total = totalDto,
                ShareDto = _mapper.Map<List<CaseFileShareDto>>(shares)
            };
            return new SuccessDataResult<CaseFileShareListDto>(caseFileShareListDto, CommonMessages.EntityListed);
        }

        public Task<IResult> Update(CaseFileShareAddDto caseFileShare)
        {
            throw new NotImplementedException();
        }
    }
}
