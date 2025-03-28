using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.EvrakDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DosyaEvrakManager : IDosyaEvrakService
    {
        IDosyaEvrakDal _dosyaEvrakDal;
        readonly IMapper _mapper;
        public DosyaEvrakManager(IDosyaEvrakDal dosyaEvrakDal, IMapper mapper)
        {
            _dosyaEvrakDal = dosyaEvrakDal;
            _mapper = mapper;
        }
        public IResult Add(DosyaEvrakEkleDto resume, string url)
        {
            // Fotoğraf yolu kaydetme işlemi
            string? sqlResimYolu = null;

            if (resume.EvrakUrl != null)
            {
                // Fotoğraf uzantısını kontrol ediyoruz
                var uzanti = Path.GetExtension(resume.EvrakUrl.FileName).ToLower();
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".docx", ".pdf", ".xlsx" };

                if (!allowedExtensions.Contains(uzanti))
                {
                    return new ErrorResult("Geçersiz dosya formatı. Sadece JPG, PNG,PDF,DOCX,XLSX kabul edilmektedir.");
                }

                // Klasör var mı kontrol ediyoruz, yoksa oluşturuyoruz
                var klasorYolu = "wwwroot/DosyaEvraklar";
                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }

                // Benzersiz dosya adı oluşturuluyor
                var tarihSaatDakikaSaniyeSalise = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                var resimYolu = Path.Combine(klasorYolu, $"{tarihSaatDakikaSaniyeSalise}{uzanti}");
                sqlResimYolu = $"{url}DosyaEvraklar/{tarihSaatDakikaSaniyeSalise}{uzanti}";

                try
                {
                    using (var stream = new FileStream(resimYolu, FileMode.Create))
                    {
                        resume.EvrakUrl.CopyTo(stream);
                    }
                }
                catch (Exception ex)
                {
                    return new ErrorResult($"Dosya kaydedilirken bir hata oluştu: {ex.Message}");
                }
            }
            DosyaEvrak evrak = _mapper.Map<DosyaEvrak>(resume);
            evrak.EvrakUrl = sqlResimYolu;
            

            _dosyaEvrakDal.AddAsync(evrak);

            return new SuccessResult("");
        }

        public IDataResult<List<DosyaEvrak>> GetAll()
        {
            List<DosyaEvrak> dosyaEvraklar = _dosyaEvrakDal.GetAll().ToList();
            return new SuccessDataResult<List<DosyaEvrak>>(dosyaEvraklar);
        }

        public IDataResult<List<DosyaEvrak>> GetAllByDosyaId(int dosyaID)
        {
            List<DosyaEvrak> dosyaEvraks = _dosyaEvrakDal.GetAll().Where(e=>e.DosyaId.Equals(dosyaID)).ToList();
            return new SuccessDataResult<List<DosyaEvrak>>(dosyaEvraks);
        }

        public IDataResult<DosyaEvrak> GetById(int evrakId)
        {
            DosyaEvrak evrak = _dosyaEvrakDal.GetByIdAsync(evrakId).Result;
            return new SuccessDataResult<DosyaEvrak>(evrak);
        }

        public IResult Update(DosyaEvrak evrak)
        {
            throw new NotImplementedException();
        }
    }
}
