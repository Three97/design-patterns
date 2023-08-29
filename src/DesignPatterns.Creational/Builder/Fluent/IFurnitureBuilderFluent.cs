using System;

namespace DesignPatterns.Creational.Builder.Fluent
{
    public interface IFurnitureBuilderFluent
    {
        IFurnitureBuilderFluent AddTitle();
        IFurnitureBuilderFluent AddDimensions();
        IFurnitureBuilderFluent AddLogistics(DateTime dateTime);

        InventoryReport GetDailyReport();
    }
}