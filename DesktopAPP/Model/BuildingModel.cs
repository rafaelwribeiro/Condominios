using System.Collections.Generic;
using System.Linq;

namespace DesktopAPP.Model
{
    public class BuildingModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Floors { get; set; }
        public int CityId { get; set; }
        public CityModel City { get; set; }
        //public IEnumerable<ApartmentModel> Apartments { get; set; } = Enumerable.Empty<ApartmentModel>();
    }
}
