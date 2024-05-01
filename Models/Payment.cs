namespace OnlineFoodDeliveryBackend.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string? CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? Cvc { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
