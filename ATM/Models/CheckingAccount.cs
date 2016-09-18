﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Account #")]
        //[StringLength(10,MinimumLength = 6)]
        [RegularExpression(@"\d{6,10}",ErrorMessage = "Account # must be between 6 and 10 digits.")]
        public string AccountNumber { get; set; }
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LaseName { get; set; }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public string Name
        {
            get {
                return string.Format("{0} {1}", this.FirstName, this.LaseName);
            }
        }
    }
}