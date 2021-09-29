using System;

namespace ficha_programação2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, desconto, bruto, liquido;
            //entrada de dados//
            Console.WriteLine("Cálculo de um salário Líquido de um professor,na qual será calculado o valor da hora/aula,número de aulas dadas e a % do desconto do INSS");
            Console.WriteLine("");
            Console.WriteLine("Serão dadas quantas aulas?");
            valor1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o valor cobrado por aula?");
            valor2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do desconto do INSS?");
            desconto = Double.Parse(Console.ReadLine());
            bruto = valor1 * valor2;
            liquido = bruto - (bruto * (desconto / 100));
            //texto saída de dados//
            Console.WriteLine("O salário bruto do professor é R${0}", bruto);
            Console.WriteLine("/n O salário líquido do professor é R${0}", liquido);
            Console.ReadLine();
        }
    }
}
