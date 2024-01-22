﻿using Newtonsoft.Json;

namespace Yandex.Checkout.V3
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class AuthorizationDetails
    {
        public string Rrn { get; set; }
        public string AuthCode { get; set; }
        [JsonProperty("three_d_secure")]
        public ThreeDSecure ThreeDSecure { get; set; }
    }
}
