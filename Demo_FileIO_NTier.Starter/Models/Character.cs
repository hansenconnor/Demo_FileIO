using Newtonsoft.Json;

namespace Demo_FileIO_NTier.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Character
    {
        public enum GenderType { NOTSPECIFIED, MALE, FEMALE }

        [JsonProperty(PropertyName = "Id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "Address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "Zip")]
        public string Zip { get; set; }

        [JsonProperty(PropertyName = "Age")]
        public int Age { get; set; }

        [JsonProperty(PropertyName = "Gender")]
        public GenderType Gender { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
