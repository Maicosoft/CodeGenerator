using System.Text;

static List<string> GenereerCode(int aantalCodes, int aantalLetters)
{
    List<string> codes = new();
    StringBuilder sb = new();

    Random random = new();

    string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    for (int i = 0; i < aantalCodes; i++)
    {
        var streepje = 0;
        for (int j = 0; j < aantalLetters; j++)
        {
            int index = random.Next(26);
            sb.Append(characters[index]);
            streepje++;

            if (streepje == 4)
            {
                sb.Append('-');
                streepje = 0;
            }
        }

        codes.Add(sb.ToString().TrimEnd('-'));
        sb.Clear();
    }
    return codes;
}

//Hieronder kun je aangeven hoeveel codes je wil en uit hoeveel letters elke code moet bestaan
foreach (string code in GenereerCode(25, 25))
{
    Console.WriteLine(code);
}
