using account_details_api.Data;
using account_details_api.Interface;
using account_details_api.Model;
using System.Threading.Tasks;

namespace account_details_api.BusinessLogic
{
    public class AccountDetailsServices : IAccountDetails
    {
        private readonly DataContext _context;

        public AccountDetailsServices(DataContext context)
        {
            _context = context;
        }
        public Task<AccountDeatils> DeleteAccountDetails(int accountNumber)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AccountDeatils> GetAccountDetails(int accountNumber)
        {
            return await _context.AccountDeatils.FindAsync(accountNumber);
        }

        public async Task<AccountDeatils> PostAccountDetails(AccountDeatils accountDeatils)
        {
            var  acctDetails = await _context.AccountDeatils.FindAsync(accountDeatils.AccountNumber);

            acctDetails.Balance = accountDeatils.Balance;
            accountDeatils.InterestRate = accountDeatils.InterestRate;
            accountDeatils.AccountType = accountDeatils.AccountType;

            await _context.SaveChangesAsync();

            return acctDetails;
        }

        public Task<AccountDeatils> UpdateAccountDetails(AccountDeatils accountDeatils)
        {
            throw new System.NotImplementedException();
        }
    }
}
