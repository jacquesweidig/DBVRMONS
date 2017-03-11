namespace CloudantDotNet.Models
{
    public class ToDoItem
    {
        public string id { get; set; }
        public string rev { get; set; }
        public string text { get; set; }

    }
    public class VREntryItem
    {
        public string id { get; set; }
        public string rev { get; set; }
        public string caseName { get; set; }
        public int mark { get; set; }
        public string comment { get; set; }
    }

}