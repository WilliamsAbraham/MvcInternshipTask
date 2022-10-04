namespace PosApp.Models
{
    public class RceiptViewModel
    {
        public MerchantDetails merchant { get; set; }
        public PurchaseDetails purchase { get; set; }
        public CardDetails card { get; set; }
        public TransactionDetails transaction { get; set; }

    }
}
