namespace Calculadora.ConsoleApp1 {
    internal class Program {

        static void Main(string[] args) {

            while (true) {
                Console.WriteLine("Bem vindo a Calculadora! \nPor favor, seleciona a opção desejada:");
                Console.WriteLine("1 - Adição \n2 - Subtração \n3 - Multiplicação\n4 - Divisão\n0 - Sair\n");

                try {
                    int op = int.Parse(Console.ReadLine());
                    if (op == 0)
                        System.Environment.Exit(0);
                    Console.Clear();
                    OperacaoCalc(op);
                }
                catch (Exception ex) {
                    Console.Clear();
                    Console.WriteLine("Apenas números são aceitos, tente novamente!\n");
                }
            }
        }
        public static void OperacaoCalc(int op) {
            double n1, n2;
            string finalizar;
            switch (op) {
                case 1:
                    do {
                        Console.WriteLine("Informe o primeiro numero a ser somado:");
                        try {
                            n1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o segundo  numero a ser somado:");
                            n2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"O resultado da soma é: {n1 + n2}");
                        }
                        catch (Exception ex) {
                            Console.WriteLine("Apenas números são aceitos, tente novamente!\n");
                        }
                        Console.WriteLine("Deseja realizar mais uma operação? [S/N]");
                        finalizar = Console.ReadLine().ToUpper();
                        Console.Clear();
                    } while (finalizar.Equals("S"));
                    break;
                case 2:
                    do {
                        Console.WriteLine("Informe o primeiro numero a ser subtraído:");
                        try {
                            n1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o segundo  numero a ser subtraído:");
                            n2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"O resultado da soma é: {n1 - n2}");
                        }
                        catch (Exception ex) {
                            Console.WriteLine("Apenas números são aceitos, tente novamente!\n");
                        }
                        Console.WriteLine("Deseja realizar mais uma operação? [S/N]");
                        finalizar = Console.ReadLine().ToUpper();
                        Console.Clear();
                    } while (finalizar.Equals("S"));
                    break;
                case 3:
                    do {
                        Console.WriteLine("Informe o primeiro numero a ser multiplicado:");
                        try {
                            n1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o segundo  numero a ser multiplicado:");
                            n2 = double.Parse(Console.ReadLine());
                            Console.WriteLine($"O resultado da soma é: {n1 * n2}");
                        }
                        catch (Exception ex) {
                            Console.WriteLine("Apenas números são aceitos, tente novamente!\n");
                        }
                        Console.WriteLine("Deseja realizar mais uma operação? [S/N]");
                        finalizar = Console.ReadLine().ToUpper();
                        Console.Clear();
                    } while (finalizar.Equals("S"));

                    break;
                case 4:
                    do {
                        try {
                            Console.WriteLine("Informe o primeiro numero a ser dividido:");
                            n1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o segundo  numero a ser dividido:");
                            n2 = double.Parse(Console.ReadLine());
                            if (n2 == 0)
                                Console.WriteLine("Não é possivel realizar divisão por zero\n");
                            else
                                Console.WriteLine($"O resultado da soma é: {n1 / n2}\n");
                        }
                        catch (Exception ex) {
                            Console.WriteLine("Apenas números são aceitos, tente novamente!\n");
                        }
                        Console.WriteLine("Deseja realizar mais uma operação? [S/N]");
                        finalizar = Console.ReadLine().ToUpper();
                        Console.Clear();
                    } while (finalizar.Equals("S"));
                    break;
                default:
                    Console.WriteLine("Opção Inválida, por favor tente novamente!");
                    break;
            }

        }
    }
}
