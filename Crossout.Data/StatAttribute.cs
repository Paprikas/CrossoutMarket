﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Crossout.Data
{
    public enum StatType
    {
        Exposed,
        Hidden,
        Misc
    }

    [JsonObject(ItemTypeNameHandling = TypeNameHandling.None)]
    public class StatAttribute : Attribute
    {
        public const String PowerScoreClasses = "stat-heading-3";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("showProgressBar")]
        public bool ShowProgressBar { get; set; }

        [JsonProperty("showPercentage")]
        public bool ShowPercentage { get; set; }

        [JsonProperty("showAddition")]
        public bool ShowAddition { get; set; }

        [JsonProperty("showSubtraction")]
        public bool ShowSubtraction { get; set; }

        [JsonProperty("customClasses")]
        public string CustomClasses { get; set; }
        
        [JsonProperty("type")]
        public StatType Type { get; set; } = StatType.Exposed;

        public StatAttribute(string name, int order = 0)
        {
            this.Name = name;
            this.Order = order;
        }

        [JsonIgnore]
        public override object TypeId => GetType();
    }
}
