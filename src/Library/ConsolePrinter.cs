namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(ITextProvider textProvider)
        {
            Console.WriteLine(textProvider.GetTextToPrint());
        }
    }
}
