namespace WindDirectionalRadarChart
{

    public class ViewModel
    {
        public List<ClimateData> BrasiliaData { get; set; }
        public List<ClimateData> TokyoData { get; set; }
        public List<ClimateData> LondonData { get; set; }
        public List<ClimateData> NairobiData { get; set; }

        public ViewModel()
        {
            BrasiliaData = new List<ClimateData>
            {
                new() { Direction = "North",DirectionShortForm="N", Brasilia = 11 },
                new() { Direction = "NorthEast",DirectionShortForm="NE", Brasilia = 9 },
                new() { Direction = "East",DirectionShortForm="E", Brasilia = 36 },
                new() { Direction = "SouthEast",DirectionShortForm="SE", Brasilia = 15 },
                new() { Direction = "South",DirectionShortForm="S", Brasilia = 7 },
                new() { Direction = "SouthWest",DirectionShortForm="SW", Brasilia = 3 },
                new() { Direction = "West",DirectionShortForm="W", Brasilia = 6 },
                new() { Direction = "NorthWest",DirectionShortForm="NW", Brasilia = 12 }
            };
            
            var brush = new SolidColorBrush(Color.FromArgb("#A32FFF"));
            BrasiliaData.ForEach(data => data.SolidColorBrush = brush);

            TokyoData = new List<ClimateData>
            {
                new() { Direction = "North",DirectionShortForm="N", Tokyo = 17 },
                new() { Direction = "NorthEast",DirectionShortForm="NE", Tokyo = 10 },
                new() { Direction = "East",DirectionShortForm="E", Tokyo = 5 },
                new() { Direction = "SouthEast",DirectionShortForm="SE", Tokyo = 9 },
                new() { Direction = "South",DirectionShortForm="S", Tokyo = 23 },
                new() { Direction = "SouthWest",DirectionShortForm="SW", Tokyo = 3 },
                new() { Direction = "West",DirectionShortForm="W", Tokyo = 4 },
                new() { Direction = "NorthWest",DirectionShortForm="NW", Tokyo = 28 }
            };

            var tokyoBrush = new SolidColorBrush(Color.FromArgb("#A4B500"));
            TokyoData.ForEach(data => data.SolidColorBrush = tokyoBrush);

            LondonData = new List<ClimateData>
            {
                new() { Direction = "North",DirectionShortForm="N", London = 11 },
                new() { Direction = "NorthEast",DirectionShortForm="NE", London = 8 },
                new() { Direction = "East", DirectionShortForm = "E", London = 6 },
                new() { Direction = "SouthEast",DirectionShortForm="SE", London = 8 },
                new() { Direction = "South",DirectionShortForm="S", London = 20 },
                new() { Direction = "SouthWest",DirectionShortForm="SW", London = 19 },
                new() { Direction = "West",DirectionShortForm="W", London = 21 },
                new() { Direction = "NorthWest",DirectionShortForm="NW", London = 7 }
            };

            var londonBrush = new SolidColorBrush(Color.FromArgb("#D82591"));
            LondonData.ForEach(data => data.SolidColorBrush = londonBrush);

            NairobiData = new List<ClimateData>
            {
                new() { Direction = "North",DirectionShortForm="N", Nairobi = 11 },
                new() { Direction = "NorthEast",DirectionShortForm="NE", Nairobi = 32 },
                new() { Direction = "East",DirectionShortForm="E", Nairobi = 19 },
                new() { Direction = "SouthEast",DirectionShortForm="SE", Nairobi = 7 },
                new() { Direction = "South",DirectionShortForm="S", Nairobi = 14 },
                new() { Direction = "SouthWest",DirectionShortForm="SW", Nairobi = 10 },
                new() { Direction = "West",DirectionShortForm="W", Nairobi = 5 },
                new() { Direction = "NorthWest",DirectionShortForm="NW", Nairobi = 3 }
            };

            var nairobiBrush = new SolidColorBrush(Color.FromArgb("#FFCA61"));
            NairobiData.ForEach(data => data.SolidColorBrush = nairobiBrush);

        }
    }
}
