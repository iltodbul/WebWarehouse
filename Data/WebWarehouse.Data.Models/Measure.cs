namespace WebWarehouse.Data.Models
{
    using WebWarehouse.Data.Common.Models;

    public class Measure : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
