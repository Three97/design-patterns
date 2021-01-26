namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    using System;
    
    public class BigNumberHandler : Handler
    {
        public BigNumberHandler(Handler handler) : base(handler) 
        {
        }

        public new void Handle(ToBeProcessed toBeProcessed)
        {
            if (toBeProcessed.Value > 9999)
            {
                Console.WriteLine($"BigNumber took care of it: {toBeProcessed.Value}");
            }
            else
            {
                Console.WriteLine("BigNumberHandler not responsible for this one.");
                base.Handle(toBeProcessed);
            }
        }
    }
}