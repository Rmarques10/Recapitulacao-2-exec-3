/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
ordem crescente ou decrescente. */

string[] numero = Console.ReadLine().Split(' ');
int a = int.Parse(numero[0]);
int b = int.Parse(numero[1]);

if(a % b == 0 || b % a == 0)
{
    Console.WriteLine("São multiplos");
}
else
{
    Console.WriteLine("Não são mutiplos");
}