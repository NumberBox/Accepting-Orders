namespace WebApplicationTest.Models {
    public class Order {
        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }
        public string sender_city { get; set; }
        public string sender_address { get; set; }
        public string recipient_city { get; set; }
        public string recipient_address { get; set; }
        public string weight { get; set; }
        public DateTime date { get; set; }
    }
}
