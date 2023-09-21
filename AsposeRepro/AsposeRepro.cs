using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeRepro;

public static class Program
{
    public static void Main()
    {
        const string INPUT = "input.pptx";
        const string OUTPUT = "output.pptx";

        using Presentation presentation = new(INPUT);
        presentation.Save(OUTPUT, SaveFormat.Pptx);
    }
}
