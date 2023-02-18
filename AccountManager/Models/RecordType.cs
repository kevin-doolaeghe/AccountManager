namespace AccountManager.Models {

    public class RecordType {

        public long RecordTypeId { get; set; }

        public string? Name { get; set; }

        public string? Icon { get; set; }

        public string? Color { get; set; }

        public List<Record>? Records { get; set; }
    }
}
