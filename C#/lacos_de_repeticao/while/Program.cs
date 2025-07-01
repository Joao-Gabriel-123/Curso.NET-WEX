int numero = 5;
int contador = 1;

while (contador <= 10)
{
    Console.WriteLine($"{contador}º execução: {numero} X {contador} = {numero * contador}");

    // if (contador == 5)
    // {
    //     break;
    // }

    contador++;
}