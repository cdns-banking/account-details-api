using account_details_api.Model;
using System.Threading.Tasks;

namespace account_details_api.Interface
{
    public interface IAccountDetails
    {
        public Task<AccountDeatils> PostAccountDetails(AccountDeatils accountDeatils);

        public Task<AccountDeatils> GetAccountDetails(int accountNumber);

        public Task<AccountDeatils> UpdateAccountDetails(AccountDeatils accountDeatils);

        public Task<AccountDeatils> DeleteAccountDetails(int accountNumber);

    }
}
