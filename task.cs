string[] text = { "AI", "is", "the", "future", "of", "health,",
                  "but", "safeguards", "are", "important", "too." };

int len = text.Length;
for (int i = 0; i < len; i++)
{
    Console.Write(text[i]);
    Console.Write(" ");
}
Console.WriteLine();

string[] text2 = new string[len];

for (int i = 0, j = 0, size = 0; i < len; i++)
{
    size = text[i].Length;
    if (size <= 3)
    {
        text2[j] = text[i];
        Console.Write(text2[j]);
        Console.Write(" ");
        j +=1;
    }
}