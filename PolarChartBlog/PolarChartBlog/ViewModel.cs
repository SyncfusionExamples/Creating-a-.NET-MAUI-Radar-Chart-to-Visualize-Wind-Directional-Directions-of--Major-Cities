namespace PolarChartBlog
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
                new() { Direction = "North", Brasilia = 11 },
                new() { Direction = "NorthEast", Brasilia = 9 },
                new() { Direction = "East", Brasilia = 36 },
                new() { Direction = "SouthEast", Brasilia = 15 },
                new() { Direction = "South", Brasilia = 7 },
                new() { Direction = "SouthWest", Brasilia = 3 },
                new() { Direction = "West", Brasilia = 6 },
                new() { Direction = "NorthWest", Brasilia = 12 }
            };
            
            var brush = new SolidColorBrush(Color.FromArgb("#A32FFF"));
            BrasiliaData.ForEach(data => data.SolidColorBrush = brush);

            TokyoData = new List<ClimateData>
            {
                new() { Direction = "North", Tokyo = 17 },
                new() { Direction = "NorthEast", Tokyo = 10 },
                new() { Direction = "East", Tokyo = 5 },
                new() { Direction = "SouthEast", Tokyo = 9 },
                new() { Direction = "South", Tokyo = 23 },
                new() { Direction = "SouthWest", Tokyo = 3 },
                new() { Direction = "West", Tokyo = 4 },
                new() { Direction = "NorthWest", Tokyo = 28 }
            };

            var tokyoBrush = new SolidColorBrush(Color.FromArgb("#A4B500"));
            TokyoData.ForEach(data => data.SolidColorBrush = tokyoBrush);

            LondonData = new List<ClimateData>
            {
                new() { Direction = "North", London = 11 },
                new() { Direction = "NorthEast", London = 8 },
                new() { Direction = "East", London = 6 },
                new() { Direction = "SouthEast", London = 8 },
                new() { Direction = "South", London = 20 },
                new() { Direction = "SouthWest", London = 19 },
                new() { Direction = "West", London = 21 },
                new() { Direction = "NorthWest", London = 7 }
            };

            var londonBrush = new SolidColorBrush(Color.FromArgb("#D82591"));
            LondonData.ForEach(data => data.SolidColorBrush = londonBrush);

            NairobiData = new List<ClimateData>
            {
                new() { Direction = "North", Nairobi = 11 },
                new() { Direction = "NorthEast", Nairobi = 32 },
                new() { Direction = "East", Nairobi = 19 },
                new() { Direction = "SouthEast", Nairobi = 7 },
                new() { Direction = "South", Nairobi = 14 },
                new() { Direction = "SouthWest", Nairobi = 10 },
                new() { Direction = "West", Nairobi = 5 },
                new() { Direction = "NorthWest", Nairobi = 3 }
            };

            var nairobiBrush = new SolidColorBrush(Color.FromArgb("#FFCA61"));
            NairobiData.ForEach(data => data.SolidColorBrush = nairobiBrush);

        }
    }
}
