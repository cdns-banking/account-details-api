using account_details_api.Interface;
using account_details_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace account_details_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountDetailsController : ControllerBase
    {
        private readonly IAccountDetails _accountDetails;
        private readonly ILogger<AccountDetailsController> _logger;

        public AccountDetailsController(IAccountDetails accountDetails, ILogger<AccountDetailsController> logger)
        {
            _accountDetails = accountDetails;
            _logger = logger;
        }

        // GET api/<AccountDetailsController>/5
        [HttpGet("GetAccountDetails")]
        public async Task<ActionResult<AccountDeatils>> GetAccountDetails(int accountNumber)
        {
            try
            {
                return await _accountDetails.GetAccountDetails(accountNumber);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
            
        }

        // POST api/<AccountDetailsController>
        [HttpPost("PostAccountDetails")]
        public async Task<ActionResult<AccountDeatils>> Post([FromBody] AccountDeatils accountDeatils)
        {
            try
            {
                return await _accountDetails.PostAccountDetails(accountDeatils);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
           
        }

        // PUT api/<AccountDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
