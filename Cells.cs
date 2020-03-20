using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public class Cells
    {
        [JsonPropertyName("isAlive")]
        public bool isAlive { get; set; }
        
        [JsonPropertyName("red")]
        public int red { get; set; }
        
        [JsonPropertyName("green")]
        public int green { get; set; }
        
        [JsonPropertyName("blue")]
        public int blue { get; set; }

        public Cells()
        {
            isAlive = false;
            red = -1;
            green = -1;
            blue = -1;
        }

    }
}
