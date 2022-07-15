using System.ComponentModel.DataAnnotations;

namespace InspectionApi.Model
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public String InsepctionName { get; set; } = String.Empty;
    }
}
