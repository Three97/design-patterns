namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    using System;
    
    public class ThousandsHandler : Handler
    {
        public ThousandsHandler(Handler handler) : base(handler)
        {
        }

        public new void Handle(ToBeProcessed toBeProcessed)
        {
            if (toBeProcessed.Value > 999 && toBeProcessed.Value < 10000)
            {
                Console.WriteLine($"ThousandsHandler took care of it: {toBeProcessed.Value}");
            }
            else
            {
                Console.WriteLine("ThousandsHandler not responsible for this one.");
                base.Handle(toBeProcessed);
            }
        }
    }
}