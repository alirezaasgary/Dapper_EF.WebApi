using System.ComponentModel.DataAnnotations;

namespace Dapper_EF.WebApi.DTOs
{
    public class DepartmentDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
