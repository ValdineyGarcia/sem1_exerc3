double nota1, nota2, nota3;
double mediaTotal;
Console.WriteLine("Bem vindo aluno! Informe sua primeira nota (0 - 10):");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a segunda nota (0 - 10):");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a terceira nota (0 - 10):");
nota3 = double.Parse(Console.ReadLine());
mediaTotal = (nota1 + nota2 + nota3)/3;
    if(mediaTotal >= 6 && mediaTotal <= 10) {
    Console.WriteLine($"Parabéns! Você está aprovado com média {mediaTotal}");
}
    else if(mediaTotal >= 5 && mediaTotal < 6 ) {
    Console.WriteLine($"Você está em recuperação com média {mediaTotal}");
}
    else {
        Console.WriteLine($"Com a média {mediaTotal}, você está reprovado!");
    }
