using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITokenService
    {
        public Task<GenerateTokenResponseDto> GenerateToken(GenerateTokenRequestDto request);
    }
}
