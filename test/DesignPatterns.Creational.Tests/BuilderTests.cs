using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Builder.Fluent;

namespace DesignPatterns.Creational.Tests;

public class BuilderTests
{
    private IEnumerable<FurnitureItem>? _furnitureItems;

    [SetUp]
    public void Setup()
    {
        this._furnitureItems = new List<FurnitureItem>
        {
            new("Sectional Couch", 55.5, 22.5, 78.6, 35.0),
            new("Nightstand", 25.0, 12.4, 20.0, 10.0),
            new("Dining Table", 105.0, 35.4, 100.6, 55.5)
        };
    }
    
    [Test]
    public void NonFluentWay()
    {
        var inventoryBuilder = new DailyReportBuilder(this._furnitureItems);
        var director = new InventoryBuildDirector(inventoryBuilder);

        director.BuildCompleteReport();
        var directorReport = inventoryBuilder.GetDailyReport();

        Console.WriteLine(directorReport.Debug());
    }

    [Test]
    public void FluentWay()
    {
        var inventoryBuilder = new DailyReportBuilderFluent(this._furnitureItems)
            .AddTitle()
            .AddDimensions()
            .AddLogistics(DateTime.Now)
            .GetDailyReport();

        Console.WriteLine(inventoryBuilder.Debug());
    }
}