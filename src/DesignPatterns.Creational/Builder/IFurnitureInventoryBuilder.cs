using System;

namespace DesignPatterns.Creational.Builder
{
    public interface IFurnitureInventoryBuilder
    {
        void AddTitle();
        void AddDimensions();
        void AddLogistics(DateTime dateTime);

        InventoryReport GetDailyReport();
    }
}