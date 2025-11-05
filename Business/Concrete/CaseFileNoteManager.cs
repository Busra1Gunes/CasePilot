using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.CaseFileDto;
using Entities.Dto.HesapHareketDto;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IDataResult<List<CaseFileNoteListDto>>> GetByCaseFileId(int caseFileId)
        {
            var notes = _noteDal
                                .Where(n => n.CaseFileID == caseFileId)
                                .Include(u=>u.User)
                                .Include(c=>c.CaseFile)
                                .OrderByDescending(n => n.NoteDate)
                                .ToList();

            var dto = _mapper.Map<List<CaseFileNoteListDto>>(notes);
            return new SuccessDataResult<List<CaseFileNoteListDto>>(dto);
        }
        public async Task<IResult> Add(CaseFileNoteAddDto noteDto)
        {
            var note = _mapper.Map<CaseFileNoteAddDto, CaseFileNote>(noteDto);

            await _noteDal.AddAsync(note);
           await _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(note.ID, CommonMessages.EntityAdded);
        }


      

        public async Task<IResult> Delete(int noteId)
        {
            var note = await _noteDal.GetByIdAsync(noteId);
            if (note == null)
                return new ErrorResult("Note not found");
            note.Status = false;
             _noteDal.Update(note);
          await  _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }

        public async Task<IDataResult<List<CaseFileNoteListDto>>> GetByUserId(int userID)
        {
            var notes = _noteDal
                               .Where(n => n.UserID == userID)
                               .Include(u => u.User)
                               .Include(c => c.CaseFile)
                               .OrderByDescending(n => n.NoteDate)
                               .ToList();

            var dto = _mapper.Map<List<CaseFileNoteListDto>>(notes);
            return new SuccessDataResult<List<CaseFileNoteListDto>>(dto);
        }
    }
}
