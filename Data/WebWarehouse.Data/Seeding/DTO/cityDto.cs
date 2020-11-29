namespace WebWarehouse.Data.Seeding.DTO
{

    using Newtonsoft.Json;

    public class CityDto
    {
        [JsonProperty("city")]
        public string Name { get; set; }
    }
}
