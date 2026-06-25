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