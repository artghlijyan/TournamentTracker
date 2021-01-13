namespace TrackerLib.Models
{
    public class PersonModel
    {
        public string FullName { get => $"{FirstName} {LastName}"; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Mobile { get; set; }
    }
}
