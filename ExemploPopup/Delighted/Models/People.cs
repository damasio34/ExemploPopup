using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploPopup.Delighted.Models
{
    public class People
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Properties Properties => new Properties();
    }

    public class Properties
    {
        [JsonProperty("purchase experience")]
        public string PurchaseExperience => "Toro Radar App";
    }
}
