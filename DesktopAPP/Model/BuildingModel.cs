namespace DesktopAPP.Model
{
    public class BuildingModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Floors { get; set; }
        public CityModel City { get; set; }
    }
}
