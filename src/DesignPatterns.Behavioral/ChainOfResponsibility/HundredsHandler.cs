namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    using System;
    
    public class HundredsHandler : Handler
    {
        public HundredsHandler(Handler handler) : base(handler)
        {
        }

        public new void Handle(ToBeProcessed toBeProcessed)
        {
            if (toBeProcessed.Value >= 0 && toBeProcessed.Value < 100)
            {
                Console.WriteLine($"HundredsHandler took care of it: {toBeProcessed.Value}");
            }
            else
            {
                Console.WriteLine("HundredsHandler not responsible for this one.");
                base.Handle(toBeProcessed);
            }
        }
    }
}