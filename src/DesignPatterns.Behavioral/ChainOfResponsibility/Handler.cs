namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        private readonly Handler _handler;

        protected Handler(Handler handler)
        {
            this._handler = handler;
        }

        public void Handle(ToBeProcessed toBeProcessed)
        {
            _handler?.Handle(toBeProcessed);
        }
    }
}