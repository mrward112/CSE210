public class Write
{
    private string _promptTitle = "";
    private string _promptDate = "";
    private string _entry = "";
    private Save _filename;

    public void Entry()
    {
        Console.Write("How was your day today? ");
        _entry = Console.ReadLine();
    }


}