namespace DesktopAPP.Model
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public void Clear()
        {
            Id = 0;
            Name = string.Empty;
            State = string.Empty;
        }
    }
}
