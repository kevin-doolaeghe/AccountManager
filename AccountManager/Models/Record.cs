namespace AccountManager.Models {

    public class Record {

        public long RecordId { get; set; }

        public string? Description { get; set; }

        public double Amount { get; set; }

        public bool Status { get; set; }

        public DateTime Date { get; set; }

        public long RecordTypeId { get; set; }

        public RecordType? RecordType { get; set; }

        public long AccountId { get; set; }

        public Account? Account { get; set; }
    }
}
