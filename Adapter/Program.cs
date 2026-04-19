public class XeroxPrinter
{
    public void PrintDocument(string document)
    {
        Console.WriteLine($"Printing Document {document}");
    }
}

public interface IPrinter
{
    void Print(string document);
}

public class XeroxPrinterAdapter : IPrinter
{
    private XeroxPrinter xeroxPrinter;
    public XeroxPrinterAdapter(XeroxPrinter xeroxPrinter)
    {
        this.xeroxPrinter = xeroxPrinter;
    }

    public void Print(string docuemnt)
    {
        xeroxPrinter.PrintDocument(docuemnt);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IPrinter printer = new XeroxPrinterAdapter(new XeroxPrinter());
        printer.Print("hello");
    }
}