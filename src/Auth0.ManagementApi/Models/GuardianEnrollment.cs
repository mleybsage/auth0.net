using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auth0.ManagementApi.Models
{
    public class GuardianEnrollment
    {
        /// <summary>
        /// Date and time when device was enrolled.
        /// </summary>
        [JsonProperty("enrolled_at")]
        public DateTime EnrolledAt { get; set; }

        /// <summary>
        /// Enrollment generated ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Device identifier (usually phone identifier).
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Date and time when device was last used for authentication.
        /// </summary>
        [JsonProperty("last_auth")]
        public DateTime LastAuth { get; set; }

        /// <summary>
        /// Name of the device which was enrolled.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Phone Number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Status of the enrollment.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GuardianEnrollmentStatus Status { get; set; }
    }
}