using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int program;

            Console.WriteLine("escreva o numero do exercicio desejado: ");
            program = int.Parse(Console.ReadLine());

            switch (program)
            {
                case 1:
                    int nm;

                    Console.WriteLine("\n" + "exercicio 1 \n");
                    Console.WriteLine("digite um nmr de 1 a 7 ");
                    nm = int.Parse(Console.ReadLine());

                    switch (nm)
                    {
                        case 1:
                            Console.WriteLine("\n" + "domingo \n");
                            break;

                        case 2:
                            Console.WriteLine("\n" + "segunda-feira \n");
                            break;
                        case 3:
                            Console.WriteLine("\n" + "terça-feira \n");
                            break;
                        case 4:
                            Console.WriteLine("\n" + "quarta-feira \n");
                            break;
                        case 5:
                            Console.WriteLine("\n" + "quinta-feira \n");
                            break;
                        case 6:
                            Console.WriteLine("\n" + "sexta-feira \n");
                            break;
                        case 7:
                            Console.WriteLine("\n" + "sábado \n");
                            break;
                        default:
                            Console.WriteLine("\n" + "nmr nao encontrado \n");
                            break;

                    }
                    break;

                case 2:
                    double v, pix, vt;

                    Console.WriteLine("\n exercicio 2\n");
                    Console.WriteLine("\n Valor de compra:  \n");
                    v = double.Parse(Console.ReadLine());
                    Console.WriteLine("\n Maneira de pagamento: \n 1. dinheiro; \n 2. pix; \n 3. cartão de Débito; \n 4. cartão de crédito.\n");
                    pix = double.Parse(Console.ReadLine());

                    switch (pix)
                    {
                        case 1:
                            vt = v * 0.85;
                            Console.WriteLine("O total é: " + vt);
                            break;

                        case 2:
                            vt = v * 0.90;
                            Console.WriteLine("O total é : " + vt);
                            break;

                        case 3:
                            vt = v * 1.05;
                            Console.WriteLine("O total é : " + vt);
                            break;

                        case 4:
                            vt = v * 1.10;
                            Console.WriteLine("O total é : " + vt);
                            break;

                        default:
                            Console.WriteLine(" invalido");
                            break;
                    }
                    break;

                case 3:
                    int m;
                    string ab;

                    Console.WriteLine("o ano é bissexto?");
                    ab = Console.ReadLine();

                    if (ab == "sim")
                    {
                        Console.WriteLine("escreva o numero do mês: ");
                        m = int.Parse(Console.ReadLine());

                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("janeiro tem 31 dias");
                                break;
                            case 2:
                                Console.WriteLine("fevereiro tem 29 dias");
                                break;
                            case 3:
                                Console.WriteLine("março tem 31 dias");
                                break;
                            case 4:
                                Console.WriteLine("abril tem 30 dias");
                                break;
                            case 5:
                                Console.WriteLine("maio tem 31 dias");
                                break;
                            case 6:
                                Console.WriteLine("junho tem 30 dias");
                                break;
                            case 7:
                                Console.WriteLine("julho tem 31 dias");
                                break;
                            case 8:
                                Console.WriteLine("agosto tem 31 dias");
                                break;
                            case 9:
                                Console.WriteLine("setembro tem 30 dias");
                                break;
                            case 10:
                                Console.WriteLine("outubro tem 31 dias");
                                break;
                            case 11:
                                Console.WriteLine("novembro tem 30 dias");
                                break;
                            case 12:
                                Console.WriteLine("dezembro tem 31 dias");
                                break;
                            default:
                                Console.WriteLine("invalido");
                                break;

                        }
                    }

                    else
                    {
                        Console.WriteLine("numero do mês: ");
                        m = int.Parse(Console.ReadLine());

                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("janeiro tem 31 dias");
                                break;
                            case 2:
                                Console.WriteLine("fevereiro tem 28 dias");
                                break;
                            case 3:
                                Console.WriteLine("março tem 31 dias");
                                break;
                            case 4:
                                Console.WriteLine("abril tem 30 dias");
                                break;
                            case 5:
                                Console.WriteLine("maio tem 31 dias");
                                break;
                            case 6:
                                Console.WriteLine("junho tem 30 dias");
                                break;
                            case 7:
                                Console.WriteLine("julho tem 31 dias");
                                break;
                            case 8:
                                Console.WriteLine("agosto tem 31 dias");
                                break;
                            case 9:
                                Console.WriteLine("setembro tem 30 dias");
                                break;
                            case 10:
                                Console.WriteLine("outubro tem 31 dias");
                                break;
                            case 11:
                                Console.WriteLine("novembro tem 30 dias");
                                break;
                            case 12:
                                Console.WriteLine("dezembro tem 31 dias");
                                break;
                            default:
                                Console.WriteLine("invalido");
                                break;

                        }
                    }
                    break;

                case 4:
                    int a, b, r;
                    char car;

                    Console.WriteLine("valor de A: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("valor de B: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("escreva uma operação: ");
                    car = char.Parse(Console.ReadLine());
                    switch (car)
                    {
                        case '+':
                            Console.WriteLine(a + b);
                            break;

                        case '-':
                            Console.WriteLine(a - b);
                            break;

                        case '*':
                            Console.WriteLine(a * b);
                            break;

                        case '/':
                            Console.WriteLine(a / b);
                            break;

                        default:
                            Console.WriteLine("invalido");
                            break;
                    }

                    break;

                case 5:

                    double c, sa, sn, dif;

                    Console.WriteLine("nmr do seu cargo: ");
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine("seu salario: ");
                    sa = double.Parse(Console.ReadLine());

                    switch (c)
                    {
                        case 101:
                            sn = sa * 1.075;
                            dif = sn % sa;
                            Console.WriteLine("O salário antigo era de: R$" + sa + ", o salario novo é de: R$" + sn + " e a diferença é de: R$" + dif);
                            break;

                        case 102:
                            sn = sa * 1.097;
                            dif = sa % sn;
                            Console.WriteLine("O salário antigo era de: R$" + sa + ", o salario novo é de: R$" + sn + " e a diferença é de: R$" + dif);
                            break;

                        case 103:
                            sn = sa * 1.117;
                            dif = sa % sn;
                            Console.WriteLine("O salário antigo era de: R$" + sa + ", o salario novo é de: R$" + sn + " e a diferença é de: R$" + dif);
                            break;

                        case 204:
                            sn = sa * 1.089;
                            dif = sa % sn;
                            Console.WriteLine("O salário antigo era de: R$" + sa + ", o salario novo é de: R$" + sn + " e a diferença é de: R$" + dif);
                            break;

                        case 206:
                            sn = sa * 1.1324;
                            dif = sa % sn;
                            Console.WriteLine("O salário antigo era de: R$" + sa + ", o salario novo é de: R$" + sn + " e a diferença é de: R$" + dif);
                            break;

                        case 301:
                            sn = sa * 1.104;
                            dif = sa % sn;
                            Console.WriteLine("O salário antigo era de: R$" + sa + ", o salario novo é de: R$" + sn + " e a diferença é de: R$" + dif);
                            break;

                        case 302:
                            sn = sa * 1.146;
                            dif = sa % sn;
                            Console.WriteLine("O salário antigo era de: R$" + sa + ", o salario novo é de: R$" + sn + " e a diferença é de: R$" + dif);
                            break;
                        default:
                            sn = sa * 1.435;
                            dif = sa % sn;
                            Console.WriteLine("O salário antigo era de: R$" + sa + ", o salario novo é de: R$" + sn + " e a diferença é de: R$" + dif);
                            break;
                    }
                    break;

                case 6:
                    double sal, sl, imp;

                    Console.WriteLine("diga seu salário:");
                    sal = double.Parse(Console.ReadLine());

                    if (sal < 1903.98)
                    {
                        Console.WriteLine("nao tem imposto");
                    }
                    else if (sal >= 1903.99 && sal <= 2826.65)
                    {
                        sl = sal - sal * 0.075;
                        imp = sal % sl;
                        Console.WriteLine("o seu salario liquido é de: R$" + sl + " e o imposto foi de: R$" + imp);
                    }
                    else if (sal >= 2826.66 && sal <= 3751.05)
                    {
                        sl = sal - sal * 0.15;
                        imp = sal % sl;
                        Console.WriteLine("o seu salario liquido é de: R$" + sl + " e o imposto foi de: R$" + imp);
                    }
                    else if (sal >= 3751.06 && sal <= 4664.68)
                    {
                        sl = sal - sal * 0.225;
                        imp = sal % sl;
                        Console.WriteLine("o seu salario liquido é de: R$" + sl + " e o imposto foi de: R$" + imp);
                    }
                    else
                    {
                        sl = sal - sal * 0.275;
                        imp = sal % sl;
                        Console.WriteLine("o seu salario liquido é de: R$" + sl + " e o imposto foi de: R$" + imp);
                    }
                    break;


                default:
                    Console.WriteLine("invalido");
                    break;
            }
        }
    }
}