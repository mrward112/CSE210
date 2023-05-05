// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Board _board = new Board();

_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us the spirit of fear; but of power, and of love...",
        new Source("2 Timothy 1: 7")
    )
);

_board.AddQuote(
    new Quote(
        "Sister Elaine S. Dalton",
        "Work hard to achieve your dreams. Don't let discouragment or mistakes delay you.",
        new Source(
            "How to Dare Great Things",
            "ChurchofJesusChrist.org"
        )
    )
);

_board.AddQuote(new Quote("Alma", "If ye have faith ye hope for things which are not seen, which are true",new Source("Alma 32:21")));

_board.AddQuote(new Quote("Alma","Live in thanksgiving daily.", new Source("Alma 34:38")));

_board.AddQuote(new Quote("Alma","Counsel with the Lord in all thy doings, and he will direct thee for good. ",new Source("Alma 37:37")));

Source source = new Source("Non were with Him", "http://churchofjesuschrist.org");


// _board.GetRandomQuote();\

Menu _menu = new Menu(_board);
_menu.Display();