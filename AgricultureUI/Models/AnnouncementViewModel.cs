namespace AgricultureUI.Models
{
    public class AnnouncementViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime NewsDate { get; set; }
        public bool Status { get; set; }
    }
}
