using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.CaseFileDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CaseFileNoteManager : ICaseFileNoteService
    {
        private readonly ICaseFileNoteDal _noteDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CaseFileNoteManager(ICaseFileNoteDal noteDal, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _noteDal = noteDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<List<CaseFileNoteDto>>> GetByCaseFileId(int caseFileId)
        {
            var notes = _noteDal.GetAllQueryable()
                                .Where(n => n.CaseFileID == caseFileId)
                                .OrderByDescending(n => n.CreatedDate)
                                .ToList();

            var dto = _mapper.Map<List<CaseFileNoteDto>>(notes);
            return new SuccessDataResult<List<CaseFileNoteDto>>(dto);
        }

        public async Task<IResult> Add(CaseFileNoteAddDto noteDto)
        {
            var entity = _mapper.Map<CaseFileNote>(noteDto);
            await _noteDal.AddAsync(entity);
            _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(entity.ID, CommonMessages.EntityAdded);
        }

        public async Task<IResult> Delete(int noteId)
        {
            var note = await _noteDal.GetByIdAsync(noteId);
            if (note == null)
                return new ErrorResult("Note not found");
            note.Status = false;
             _noteDal.Update(note);
            _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }
    }
}
