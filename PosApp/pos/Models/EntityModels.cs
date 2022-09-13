using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PosApp.Models
{
    public class MerchantDetails
    {
        public int Id { get; set; }
        [Display(Name = "MERCHANT NAME :")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "LOCATION :")]
        [Required]
        public string Address { get; set; }
        [Display(Name = "TERMINAL ID :")]
        [Required]
        public string TerminalId { get; set; }    }

    public class PurchaseDetails
    {
        public int Id { get; set; }
        [Display(Name = "STAN :")]
        [Required]
        public string Stan { get; set; }
        [Display(Name = "DATE / TIME :")]
        [Required]
        public DateTime Date { get; set; }
        //[DataType(DataType.Currency)]
        [Range(1, 100)]
        [Display(Name = "AMOUNT :")]
        [Required]
        public double Amount { get; set; }

    }

    public class CardDetails
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        [Required]
        public string Cardnumber { get; set; }
        public string IssuerLocation { get; set; }
        [Display(Name = "EXPIRY DATE :")]
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Display(Name ="AUTHORIZATION CODE:")]
        [Required]
        public string AuthorizationCode { get; set; }
        [Required]
        public String CvnType { get; set; }
    }

    public class TransactionDetails
    {
        public int Id { get; set; }
        [Display(Name = "RESPONSE CODE :")]
        [Required]
        public int ResponseCode { get; set; }
        [Display(Name = "AID :")]
        [Required]
        public string Aid { get; set; }
        [Display(Name = "RRN :")]
        [Required]
        public string Rrn { get; set; }
        [Display(Name = "PTAD :")]
        [Required]
        public string Ptad { get; set; }

    }

}
