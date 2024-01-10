namespace FAQ.Shared
{
    public class FAQs
    {
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? Topic { get; set; }
        public string? Category { get; set; }
    }

    public class Filter
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }

    [Flags]
    public enum TopicEnum
    {
        None,
        Bootstrap,
        CSharp,
        Javascript,
    }

    public enum CategoryEnum
    {
        None,
        General,
        History
    }
}