// our program needs to use the IPrinter interface however the library
// has its own printer driver called XeronPrinter. We create a IPrinter named
// XeronPrinterAdapter this contains the class we are adapting and plugs into
// the IPrinter class.

public class Program
{
    public static void Main(string[] args)
    {
        IPrinter printer = new XeroxPrinterAdapter(new XeroxPrinter());
        printer.Print("hello");
    }
}
