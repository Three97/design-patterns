using System;

namespace DesignPatterns.Creational.Builder
{
    public class InventoryBuildDirector
    {
        private IFurnitureInventoryBuilder _builder;

        public InventoryBuildDirector(IFurnitureInventoryBuilder builder)
        {
            this._builder = builder;
        }

        public void BuildCompleteReport()
        {
            this._builder.AddTitle();
            this._builder.AddDimensions();
            this._builder.AddLogistics(DateTime.Now);
        }
    }
}