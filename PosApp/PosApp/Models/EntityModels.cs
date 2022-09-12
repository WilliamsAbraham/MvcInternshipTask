using System;

namespace PosApp.Models
{
    public class MerchantDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string  TerminalId { get; set; }
    }

    public class PurchaseDetails
    {
        public int PurchaseId { get; set; }
        public string Stan { get; set; }
        public DateTime date { get; set; }
        public decimal Amount { get; set; }

    }

    public class CardDetails
    {
        public int CardId { get; set; }
        public string CardType { get; set; }
        public string  IssuerLocation { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string AuthorizationCode { get; set; }
    }

    public class TransactionDetails
    {
        public int TransactionId { get; set; }
        public string ResponseCode { get; set; }
        public string Aid { get; set; }
        public string Rrn { get; set; }
        public string Ptad { get; set; }

    }


}
