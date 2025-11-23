namespace Business
{
    using Business.Entities;
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.WriteLine("Digite quantos funcionários serão registrados : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do funcionário #{i}");
                Console.WriteLine("Qual o nome do funcionário: ");
                string name = Console.ReadLine();
                Console.WriteLine("O funcionário é terceirazado(s/n): ");
                String resposta = Console.ReadLine();
                Console.WriteLine("Quantas horas o funcionário trabalhou: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor por hora do funcionário: ");
                double value_hour = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (resposta == "sim")
                {
                    Console.WriteLine("Digite o valor que  você deseja adicionar");
                    double additional_charge = double.Parse(Console.ReadLine());
                    employees.Add(new OutEmployee(name,hours, value_hour, additional_charge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, value_hour));
                }

               

            }

            Console.WriteLine(" ");
            Console.WriteLine("Mostrando os dados obtidos: ");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"));
            }
        }
    }
}