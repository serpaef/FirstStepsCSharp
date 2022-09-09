namespace FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2147483647;
            long y = 2147483647L;
            
            Console.WriteLine("limite tamanho int: " + x);
            Console.WriteLine("A partir disso, usa-se long: " + y);

            bool z = true;
            char a = '\u0041';
            float b = 123.456f;
            double c = 123.45;
            string d = "Fernando";
            object e = 6.2f;

            Console.WriteLine("tipo bool se declara com 'bool': " + z);
            Console.WriteLine("tipo char serve para caracteres unicode: " + a);
            Console.WriteLine("float para decimais de até 4 bytes: " + b);
            Console.WriteLine("double para decimais de até 8 bytes: " + c);
            Console.WriteLine("strings necessitam de aspas duplas para declaração: " + d);
            Console.WriteLine("object é um tipo genérico que aceita qualquer tipo de dados sob o custo de ser mais pesado, nesse caso se trata de um float: " + e);
            Console.WriteLine("------------------------");

            string nome = "Fernando";
            int idade = 27;
            double saldo = 30.46588;

            // Usando Placeholders

            Console.WriteLine("{0} tem {1} anos e seu saldo é {2:F2} reais", nome, idade, saldo);
        }
    }
}
