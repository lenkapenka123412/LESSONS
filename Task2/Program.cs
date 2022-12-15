//Замена символов
string text = "В нору забилась старенькая осень, "
            + "Понабросала листьев, как лисят. "
            + "Друзей уносит. И врагов уносит. "
            + "Лет в сорок восемь или пятьдесят.";

string RepLace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = RepLace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = RepLace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = RepLace(text, 'с', 'С');
Console.WriteLine(newText);