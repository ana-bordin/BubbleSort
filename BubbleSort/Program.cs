// 3. faça um programa que leia 5 números em um vetor e ordene-os no segundo vetor;
//bubble sort

int tamanho = 5;
int[] vetorOriginal = new int[tamanho];
int[] vetorOrdenado = new int[tamanho];
int aux;

Console.WriteLine("\nVetor sem ordenação:");

for (int i = 0; i < 5; i++)
{
    vetorOriginal[i] = new Random().Next(0, 100);
    vetorOrdenado[i] = vetorOriginal[i];    
    Console.Write($"{vetorOrdenado[i]}, ");
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
    }
}
Console.WriteLine("\n\nVetor com ordenação:");
for (int i = 0; i < tamanho; i++)
{
    Console.Write($"{vetorOrdenado[i]}, ");
}
Console.WriteLine("\n");