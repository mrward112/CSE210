public class Load
{

    private string _filename = "";

    public void FilenameInput()   
    {
        Console.Write("What is the filename? ");
        _filename = Console.ReadLine();
    }

    public void read_file()
    {
        using (var reader = new StreamReader(_filename))
        {
            
        }
    }

}