namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class BuildHandlerPipeline
    {
        private readonly Handler _handler;

        public BuildHandlerPipeline()
        {
            this._handler = new NegativeHandler(new HundredsHandler(new ThousandsHandler(new BigNumberHandler(null))));
        }

        public void Handle(ToBeProcessed toBeProcessed)
        {
            this._handler.Handle(toBeProcessed);
        }
    }
}