Console.WriteLine("Digite o primeiro número:");
string entrada = Console.ReadLine();
double numero = Convert.ToInt32(entrada);
Console.WriteLine("Digite o segundo número:");
string entrada2 = Console.ReadLine();
double numero2 = Convert.ToInt32(entrada2);

Console.WriteLine("A soma de: " + numero + " + " + numero2 + " é = " + (numero + numero2));

Console.WriteLine($"A subtração de: {numero} - {numero2} é = {numero - numero2}");

Console.WriteLine("A multiplicação de: {0} x {1} é = {2}", numero, numero2, numero * numero2 );

Console.WriteLine("A divisão de: {0} / {1} é = {2}", numero, numero2, numero / numero2 );


