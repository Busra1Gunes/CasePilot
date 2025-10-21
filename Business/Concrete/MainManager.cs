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
        IIncomeService _incomeService;
        IExpenseService _expenseService;
        public MainManager(ICaseFileService caseFileService, IAccountTransactionService accountTransactionService, IUserService userService, IIncomeService incomeService, IExpenseService expenseService)
        {
            _caseFileService = caseFileService;
            _accountTransactionService = accountTransactionService;
            _userService = userService;
            _incomeService = incomeService;
            _expenseService = expenseService;
        }
        public async Task<object> Totals()
        {
            int totalCaseFile =await _caseFileService.Where(c => c.Status.Equals(true)).CountAsync();
            decimal totalDept = await _accountTransactionService.Where(c => c.Status.Equals(true) && c.DebtorID == 1).SumAsync(s => s.Amount);
            decimal totalCredit = await _accountTransactionService.Where(c => c.Status.Equals(true) && c.CreditID == 1).SumAsync(s => s.Amount);
            int totalUser = await _userService.Where(u=>u.Status.Equals(true)).CountAsync();
            decimal totalIncome = await _incomeService.Where(c => c.Status.Equals(true)).SumAsync(s => s.Amount); //gelirler
            decimal totalExpense = await _expenseService.Where(c => c.Status.Equals(true) && c.PaymentStatus == 1).SumAsync(s => s.Amount); //ödenen giderler
            decimal totalIncomeExpense = totalIncome - totalExpense;
            TotalValueDto totalValueDto = new()
            {
                TotalCaseFile = totalCaseFile,
                TotalCredit = totalCredit,
                TotalDebt = totalDept,
                TotalUser = totalUser,
                TotalIncomeExpense=totalIncomeExpense
            };
            return totalValueDto;
        }
    }
}
