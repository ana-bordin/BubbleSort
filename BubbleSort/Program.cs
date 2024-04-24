//faça um programa em que o vetor 2 tenha numeros ordenados e sem repetidos;

int tamanho = 5, aux;
int[] vetorOriginal = new int[tamanho], vetorOrdenado = new int[tamanho];
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

for (int referencia = 0; referencia < tamanho; referencia++)
{
    for (int comparacao = referencia + 1; comparacao < tamanho; comparacao++)
    {
        if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
        {
            aux = vetorOrdenado[referencia];
            vetorOrdenado[referencia] = vetorOrdenado[comparacao];
            vetorOrdenado[comparacao] = aux;
        }
        else if (vetorOrdenado[referencia] == vetorOrdenado[comparacao])
            vetorOrdenado[comparacao] = 0;       
    }
}

Console.WriteLine("\n\nVetor com ordenação e com zero no lugar dos repetidos:\n");

for (int referencia = 0; referencia < tamanho; referencia++)
{
    if (zero == true)
    {
        vetorOrdenado[referencia] = 0;
        zero = false;
        Console.Write($"{vetorOrdenado[referencia]}, ");
    }
    else
    {
        for (int comparacao = referencia + 1; comparacao < tamanho; comparacao++)
        {
            if (vetorOrdenado[referencia] == 0)
            {
                vetorOrdenado[referencia] = vetorOrdenado[comparacao];
                vetorOrdenado[comparacao] = 0;
            }
        }
        Console.Write($"{vetorOrdenado[referencia]}, ");
    }    
}

Console.WriteLine("\n\nVetor com ordenação e sem repetições:");

for (int i = 0; i < tamanho; i++)
{
    if (i == 0 && vetorOrdenado[0] == 0)
        Console.Write($"{vetorOrdenado[i]}, ");
    if (vetorOrdenado[i] != 0)
        Console.Write($"{vetorOrdenado[i]}, ");
}

Console.WriteLine("\n");