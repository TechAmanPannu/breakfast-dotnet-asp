namespace BuberBreakfast.Contracts.Breakfast
{
    public class CreateBreakFastRequest {
        private string Name { get; set; } = string.Empty;
        private string Description { get; set; } = string.Empty;
        private DateTime StartDateTime { get; set; }
        private DateTime EndDateTime { get; set; }
        private List<string> Savory { get; set; } = new List<string>();
        private List<string> Sweet { get; set; } = new List<string>();
    }
}
