int sw= Console.WindowWidth;
int sh= Console.WindowHeight;

string[] lines = {
            "  .d8888.  d888888b  .d8888.   d888888b  d88888b .88b  d88.   .d8b.  ",
            " 88'  YP    `88'    88'  YP   `~~88~~'  88'     88'YbdP`88  d8' `8b ",
            " `8bo.       88     `8bo.        88     88ooooo 88  88  88  88ooo88 ",
            "   `Y8b.     88       `Y8b.      88     88~~~~~ 88  88  88  88~~~88 ",
            " db   8D    .88.    db   8D      88     88.     88  88  88  88   88 ",
            " `8888Y'  Y888888P  `8888Y'      YP     Y88888P YP  YP  YP  YP   YP ",
            "                                                                       ",
            " d88888b  db      d88888b  .o88b.  d888888b   .d88b.   d8888b.   .d8b.   db      ",
            " 88'      88      88'     d8P  Y8  `~~88~~'  .8P  Y8.  88  `8D  d8' `8b  88      ",
            " 88ooooo  88      88ooooo 8P          88     88    88  88oobY'  88ooo88  88      ",
            " 88~~~~~  88      88~~~~~ 8b          88     88    88  88`8b    88~~~88  88      ",
            " 88.      88booo. 88.     Y8b  d8     88     `8b  d8'  88 `88.  88   88  88booo. ",
            " Y88888P  Y88888P Y88888P  `Y88P'     YP      `Y88P'   88   YD  YP   YP  Y88888P "
        };

foreach (string line in lines)
{
    int space = (sw - line.Length) / 2;
    Console.WriteLine(new string(' ', space) + line);
}

Console.WriteLine("\nBienvenido al Sistema Electoral recuerda que tu voto es libre y secreto, recuerda votar a conciencia.");

string lineDec = new string('-', sw);
int votantes = ('1');

Console.WriteLine($"\n" + lineDec + "\n");
Console.WriteLine($"Votantes : {votantes} ");
Console.WriteLine($"\n" + lineDec);






