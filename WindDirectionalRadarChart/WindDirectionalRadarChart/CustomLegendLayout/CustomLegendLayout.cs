using Syncfusion.Maui.Charts;

namespace WindDirectionalRadarChart
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 1;
        }
    }
}
