//faça um programa em que o vetor 2 tenha numeros ordenados e sem repetidos;

int tamanho = 5, aux;
int[] vetorOriginal = new int[tamanho], vetorOrdenado = new int[tamanho], vetorDecrescente = new int[tamanho];
bool zero = false;

Console.WriteLine("\nVetor sem ordenação:");

for (int i = 0; i < tamanho; i++)
{
    vetorOriginal[i] = new Random().Next(0, 5);
    vetorOrdenado[i] = vetorOriginal[i];
    Console.Write($"{vetorOriginal[i]}, ");
    if (vetorOrdenado[i] == 0)
        zero = true;
}

for (int i = 0; i < tamanho; i++)
{
    for (int j = i + 1; j < tamanho; j++)
    {
        if (vetorOrdenado[i] > vetorOrdenado[j])
        {
            aux = vetorOrdenado[i];
            vetorOrdenado[i] = vetorOrdenado[j];
            vetorOrdenado[j] = aux;
        }
        else if (vetorOrdenado[i] == vetorOrdenado[j])
            vetorOrdenado[j] = 0;
    }
}

Console.WriteLine("\n\nVetor com ordenação e sem repetidos:\n");

for (int i = 0; i < tamanho; i++)
{
    if (zero == true)
    {
        vetorOrdenado[i] = 0;
        zero = false;
        Console.Write($"{vetorOrdenado[i]}, ");
    }
    else
    {
        for (int j = i + 1; j < tamanho; j++)
        {
            if (vetorOrdenado[i] == 0)
            {
                vetorOrdenado[i] = vetorOrdenado[j];
                vetorOrdenado[j] = 0;
            }
        }
        if (vetorOrdenado[i] != 0)
            Console.Write($"{vetorOrdenado[i]}, ");
    }
}

Console.WriteLine("\n\nVetor com ordenação decrescente:\n");

for (int i = 0; i < tamanho; i++)
{
    if (vetorOrdenado[tamanho - i - 1] != 0)
    {
        vetorDecrescente[i] = vetorOrdenado[tamanho - i - 1];
        Console.Write($"{vetorDecrescente[i]}, ");
    }
}
Console.WriteLine("\n");