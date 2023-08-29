using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Builder.Fluent
{
    public class DailyReportBuilderFluent : IFurnitureBuilderFluent
    {
        private InventoryReport _inventoryReport;
        private IEnumerable<FurnitureItem> _items;

        public DailyReportBuilderFluent(IEnumerable<FurnitureItem> items)
        {
            this.Reset();
            this._items = items;
        }

        public void Reset()
        {
            this._inventoryReport = new InventoryReport();
        }

        public IFurnitureBuilderFluent AddTitle()
        {
            this._inventoryReport.TitleSection = "-----  - Daily Inventory Report -  -----\n\n";

            return this;
        }

        public IFurnitureBuilderFluent AddDimensions()
        {
            this._inventoryReport.DimensionsSection =
                string.Join(Environment.NewLine, _items.Select(product => $"Product: {product.Name}\n" +
                                                                          $"Price: {product.Price}\n" +
                                                                          $"Height: {product.Height} x " +
                                                                          $"Width: {product.Width} -> " +
                                                                          $"Weight: {product.Weight} lbs\n"));

            return this;
        }

        public IFurnitureBuilderFluent AddLogistics(DateTime dateTime)
        {
            _inventoryReport.LogisticsSection = $"Report generated on {dateTime}";

            return this;
        }

        public InventoryReport GetDailyReport()
        {
            var finishedReport = this._inventoryReport;
            this.Reset();

            return finishedReport;
        }
    }
}