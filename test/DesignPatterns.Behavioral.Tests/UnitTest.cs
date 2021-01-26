namespace DesignPatterns.Behavioral.Tests
{
    using DesignPatterns.Behavioral.ChainOfResponsibility;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest
    {
        [TestInitialize]
        public void Initialize()
        {
            
        }   
        
        [TestMethod]
        public void TestTheThings()
        {
            var pipeline = new BuildHandlerPipeline();
            pipeline.Handle(new ToBeProcessed{ Value = -50});
            pipeline.Handle(new ToBeProcessed{ Value = 0});
            pipeline.Handle(new ToBeProcessed{ Value = 50});
            pipeline.Handle(new ToBeProcessed{ Value = 500});
            pipeline.Handle(new ToBeProcessed{ Value = 50000});
            pipeline.Handle(new ToBeProcessed{ Value = -5});
        }   
    }
}