namespace AccountManager.Models {

    public class Account {
    
        public long AccountId { get; set; }

        public string Name { get; set; }

        public ICollection<Record> Records { get; set; }
    }
}
