namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    using System;
    
    public class NegativeHandler : Handler
    {
        public NegativeHandler(Handler handler) : base(handler)
        {
        }
        
        public new void Handle(ToBeProcessed toBeProcessed)
        {
            if (toBeProcessed.Value < 0)
            {
                Console.WriteLine($"NegativeHandler took care of it: {toBeProcessed.Value}");
            }
            else
            {
                Console.WriteLine("NegativeHandler not responsible for this one.");
                base.Handle(toBeProcessed);
            }
        }
    }
}