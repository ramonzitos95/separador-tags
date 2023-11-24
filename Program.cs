
try
{
    Console.WriteLine("Informe as tags");
    var tags = Console.ReadLine();
    var tagsSep = tags?.Split(',') ?? null;

    if(tagsSep is null)
        Console.WriteLine("Tags não informadas");
    else 
    {
        tagsSep = tagsSep.Select(tag => tag + Environment.NewLine).ToArray();

        Console.WriteLine("Tags com quebra de linha:");
        foreach (var tag in tagsSep)
        {
            Console.WriteLine(tag);
        }
    }
} 
catch(Exception ex) {

}
