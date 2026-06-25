public class Program
{
    public static void Main(string[] args)
    {
        IPrinter printer = new XeroxPrinterAdapter(new XeroxPrinter());
        printer.Print("hello");
    }
}
