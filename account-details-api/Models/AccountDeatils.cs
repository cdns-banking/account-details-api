using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace account_details_api.Model
{
    public  class AccountDeatils
    {
        [Key]
        public int AccountNumber { get; set; }
        public int Balance { get; set; }
        public bool AccountType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal InterestRate { get; set; }
    }
}
