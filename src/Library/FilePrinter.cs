using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void Print(ITextProvider textProvider)
        {
            File.WriteAllText("Recipe.txt", textProvider.GetTextToPrint());
        }
    }
}
