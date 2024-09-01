namespace BuberBreakfast.Contracts.Breakfast
{

    
public class BreakFastResponse {

        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<string> Savory { get; set; } = new List<string>();
        public List<string> Sweet { get; set; } = new List<string>();

         // Constructor for initialization
    public BreakFastResponse(string id, string name, string description, DateTime startDateTime, DateTime endDateTime)
    {
        Id = id;
        Name = name;
        Description = description;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
    }
    }

    
}
