namespace WebWarehouse.Data.Seeding.DTO
{

    using Newtonsoft.Json;

    public class cityDto
    {
        [JsonProperty("city")]
        public string Name { get; set; }
    }
}
