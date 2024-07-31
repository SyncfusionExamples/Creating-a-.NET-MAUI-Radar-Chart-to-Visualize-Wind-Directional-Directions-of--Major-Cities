using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindDirectionalRadarChart
{
    public class ClimateData
    {
        public string? Direction { get; set; }
        public string? DirectionShortForm{ get; set; }
        public double Brasilia{ get; set; }
        public double Tokyo { get; set; }
        public double London { get; set; }
        public double Nairobi { get; set; }
        public Brush? SolidColorBrush {  get; set; }
    }
}
