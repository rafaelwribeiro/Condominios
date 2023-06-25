namespace DesktopAPP.Model
{
    public class PaymentRankingReportModel
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public int BuildingId { get; set; }
        public string BuildingName { get; set; } = "";
        public decimal SizeM2 { get; set; }
        public int Floor { get; set; }
        public int RoomQuantity { get; set; }
        public string CityName { get; set; } = "";
        public string State { get; set; } = "";
        public decimal Value { get; set; }
    }
}
