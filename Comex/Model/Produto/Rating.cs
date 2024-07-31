using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Comex.Model.Produto
{
    internal class Rating
    {
        [JsonPropertyName("rate")]
        public double Rate { get; set; }
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
