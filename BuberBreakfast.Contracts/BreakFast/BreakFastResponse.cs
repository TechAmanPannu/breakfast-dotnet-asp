namespace BuberBreakfast.Contracts.Breakfast
{


    public class BreakFastResponse
    {

        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<string> Savory { get; set; } = new List<string>();
        public List<string> Sweet { get; set; } = new List<string>();

    }


}
