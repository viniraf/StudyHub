namespace StudyHub.Models
{
    public class StudyGroupModel
    {
        public int Id { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public String Title { get; set; } = "";

        public String Description { get; set; } = "";

        public String Link { get; set; } = ""; 
    }
}
