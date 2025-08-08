using Business.Abstract;
using Entities.Dto.TotalDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MainManager : IMainService
    {
        ICaseFileService _caseFileService;
        IAccountTransactionService _accountTransactionService;
        IUserService _userService;
        public MainManager(ICaseFileService caseFileService, IAccountTransactionService accountTransactionService, IUserService userService)
        {
            _caseFileService = caseFileService;
            _accountTransactionService = accountTransactionService;
            _userService = userService;

        }
        public async Task<object> Totals()
        {
            int totalCaseFile =await _caseFileService.Where(c => c.Status.Equals(true)).CountAsync();
            decimal totalDept = await _accountTransactionService.Where(c => c.Status.Equals(true) && c.DebtorID == 1).SumAsync(s => s.Amount);
            decimal totalCredit = await _accountTransactionService.Where(c => c.Status.Equals(true) && c.CreditID == 1).SumAsync(s => s.Amount);
            int totalUser = await _userService.Where(u=>u.Status.Equals(false)).CountAsync();
            TotalValueDto totalValueDto = new()
            {
                TotalCaseFile = totalCaseFile,
                TotalCredit = totalCredit,
                TotalDebt = totalDept,
                TotalUser = totalUser
            };
            return totalValueDto;
        }
    }
}
