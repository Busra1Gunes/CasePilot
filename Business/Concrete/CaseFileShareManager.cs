using AutoMapper;
using Business.Abstract;
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
        public CaseFileShareManager(IMapper mapper, ICaseFileShareDal caseFileShareDal)
        {
            _caseFileShareDal = caseFileShareDal;
            _mapper = mapper;   
        }
        public IResult Add(CaseFileShareAddDto caseFileShareAddDto)
        {
            var caseFileShareAdd = _mapper.Map<CaseFileShareAddDto, CaseFileShare>(caseFileShareAddDto);
            _caseFileShareDal.AddAsync(caseFileShareAdd);
            return new SuccessResult();
        }

        public IDataResult<CaseFileShareListDto> GetAll()
        {
            var shares = _caseFileShareDal
                 .Where(x => x.Status == false)
                 .Include(a => a.CaseFile)
                 .Include(a => a.User);
            var sharesList = _mapper.Map<List<CaseFileShareDto>>(shares);

            var totalDto = new CaseFileShareTotalDto();

            foreach (var h in shares)
            {
                if (h.ShareRate != null)
                    totalDto.TotalShareRate += h.ShareRate;
            }


            CaseFileShareListDto caseFileShareListDto = new CaseFileShareListDto
            {
              Total=totalDto,
              ShareDto = sharesList
            };


            return new SuccessDataResult<CaseFileShareListDto>(caseFileShareListDto);
        }

        public IDataResult<CaseFileShareListDto> GetAllByCaseFileID(int caseFileID)
        {
            var shares = _caseFileShareDal
                 .Where(x => x.Status == false && x.CaseFileID == caseFileID)
                 .Include(a => a.CaseFile)
                 .Include(a => a.User);
            var sharesList = _mapper.Map<List<CaseFileShareDto>>(shares);

            var totalDto = new CaseFileShareTotalDto();

            foreach (var h in shares)
            {
                if (h.ShareRate != null)
                    totalDto.TotalShareRate += h.ShareRate;
            }


            CaseFileShareListDto caseFileShareListDto = new CaseFileShareListDto
            {
                Total = totalDto,
                ShareDto = sharesList
            };
            return new SuccessDataResult<CaseFileShareListDto>(caseFileShareListDto);
        }

        public IDataResult<CaseFileShareDto> GetById(int shareID)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CaseFileShareAddDto caseFileShare)
        {
            throw new NotImplementedException();
        }
    }
}
