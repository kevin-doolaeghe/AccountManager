namespace AccountManager.Models {

    public class Account {

        public long AccountId { get; set; }

        public string? Name { get; set; }

        public long UserId { get; set; }

        public User? User { get; set; }

        public List<Record>? Records { get; set; }
    }
}
