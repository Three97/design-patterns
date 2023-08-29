using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Builder
{
    public class DailyReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport _inventoryReport;
        private IEnumerable<FurnitureItem> _items;

        public DailyReportBuilder(IEnumerable<FurnitureItem> items)
        {
            this.Reset();
            this._items = items;
        }

        public void AddTitle()
        {
            this._inventoryReport.TitleSection = "-----  - Daily Inventory Report -  -----\n\n";
        }

        public void AddDimensions()
        {
            this._inventoryReport.DimensionsSection = 
                string.Join(Environment.NewLine, _items.Select(product => $"Product: {product.Name}\n" +
                                                                          $"Price: {product.Price}\n" +
                                                                          $"Height: {product.Height} x " +
                                                                          $"Width: {product.Width} -> " + 
                                                                          $"Weight: {product.Weight} lbs\n"));
        }

        public void AddLogistics(DateTime dateTime)
        {
            _inventoryReport.LogisticsSection = $"Report generated on {dateTime}";
        }

        public InventoryReport GetDailyReport()
        {
            var finishedReport = _inventoryReport;
            Reset();

            return finishedReport;
        }

        public void Reset()
        {
            this._inventoryReport = new InventoryReport();
        }
    }
}