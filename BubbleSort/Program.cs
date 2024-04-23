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
    {
        zero = true;
    }
}

for (int referencia = 0; referencia < tamanho - 1; referencia++)
{
    for (int comparacao = referencia + 1; comparacao < tamanho; comparacao++)
    {
        if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
        {
            aux = vetorOrdenado[referencia];
            vetorOrdenado[referencia] = vetorOrdenado[comparacao];
            vetorOrdenado[comparacao] = aux;
            
        }
        if (vetorOrdenado[referencia] == vetorOrdenado[comparacao])
        {
            vetorOrdenado[comparacao] = 0;
        }
    }
}

Console.WriteLine("\n\nVetor com ordenação:");
for (int i = 0; i < tamanho; i++)
    if (vetorOrdenado[i] == 0)
    {
        if (zero == true)
        {
            Console.Write($"{vetorOrdenado[i]}, ");
            zero = false;
        }
    }
    else
    {
        Console.Write($"{vetorOrdenado[i]}, ");
    }

Console.WriteLine("\n");