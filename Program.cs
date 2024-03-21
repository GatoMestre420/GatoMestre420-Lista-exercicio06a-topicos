Console.Clear();
//Criar um vetor


int[] vetor = new int[100];
int[] vet = new int[100];
//criar o objeto que vai gerar o número randomico
Random aleatorio = new Random();

//preencher vetor com valores aleatórios 
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = aleatorio.Next(100) + 1;
}

//Imprimir Vetor
for (int i = 0; i < vetor.Length; i++)
{

    Console.Write(vetor[i] + " ");
}
//ordenar o vetor por ordem crescente

bool troca = false;
do
{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {

        if (vetor[i] > vetor[i + 1])
        {
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            troca = true;
        }


    }
} while (troca == true);

Console.Write("\n\n");

// imprimir pela segunda vez ordenado
for (int i = 0; i < vetor.Length; i++)
{

    Console.Write(vetor[i] + " ");
}