using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class InventoryReport
    {
        public string TitleSection { get; set; }
        public string DimensionsSection { get; set; }
        public string LogisticsSection { get; set; }

        public string Debug()
        {
            return new StringBuilder()
                .AppendLine(this.TitleSection)
                .AppendLine(this.DimensionsSection)
                .AppendLine(this.LogisticsSection)
                .ToString();
        }
    }
}