List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MS");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MS");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

//Percorrendo listas com FOR

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição N° {i}: {listaString[i]}");
}

//Percorrendo listas com FOREACH

int contador = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição N° {contador}: {item}");
    contador++;
}