namespace DesktopAPP.Model
{
    public class ApartmentModel
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public BuildingModel Building { get; set; }
        public int Floor { get; set; }
        public int BadroomsQuantity { get; set; }
        public string DisplayName => $"Ap. {Id} Andar {Floor}";
    }
}
