using System;
using System.Globalization;

namespace curso_logica
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();

        }
    }
}


//swhit case

//int x = int.Parse(Console.ReadLine());
//string dia;

//switch (x)
//{
//    case 1:
//        dia = "Domingo";
//        break;

//    case 2:
//        dia = "segunda";
//        break;

//    case 3:
//        dia = "terça";
//        break;

//    case 4:
//        dia = "quarta";
//        break;

//    case 5:
//        dia = "quinta";
//        break;

//    case 6:
//        dia = "sexta";
//        break;

//    case 7:
//        dia = "sabado";
//        break;

//    default:
//        dia = "valor invalido";
//        break;
//}
//Console.WriteLine("dia da semana: " + dia);



//estruturas condicionais

//int x, y, z;
//string[] vetor = Console.ReadLine().Split(' ');
//x = int.Parse(vetor[0]);
//y = int.Parse(vetor[1]);
//z = int.Parse(vetor[2]);

//            if (x<y && x<z)
//            {
//                Console.WriteLine("MENOR = " + x);
//            }
//            else
//            {
//                if (y<z)
//                {
//                    Console.WriteLine("MENOR = " + y);
//                }
//                else
//                {
//                    Console.WriteLine("MENOR = " + z);
//                }
//            }


//=========================
//double A, B, C, X, DELTA, r1, r2;

//string[] vetor = Console.ReadLine().Split(' ');

//A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
//B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
//C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

//DELTA = Math.Pow(B, 2.0) - 4 * A * C;


//            if (A==0 || DELTA<0.0)
//            {
//                Console.WriteLine("IMPOSSIVEL CALCULAR");
//            }
//            else
//            {
//                r1 = (-B + Math.Sqrt(DELTA)) / (2.0 * A);
//                r2 = (-B - Math.Sqrt(DELTA)) / (2.0 * A);

//                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
//                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
//                Console.ReadKey();
//======================






//double nota1, nota2, soma;
//nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//soma = nota1 + nota2;

//Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));
//if (soma < 60.0)
//{
//    Console.WriteLine("REPROVADO");
//}
//Console.ReadLine();




//=================================================================================
//double N;
//int quociente, resto, nota, moeda;

//N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//resto = (int)(N * 100.0 + 0.5);

//Console.WriteLine("NOTAS:");

//nota = 100;
//quociente = resto / (nota * 100);
//Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//resto = resto % (nota * 100);

//nota = 50;
//quociente = resto / (nota * 100);
//Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//resto = resto % (nota * 100);

//nota = 20;
//quociente = resto / (nota * 100);
//Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//resto = resto % (nota * 100);

//nota = 10;
//quociente = resto / (nota * 100);
//Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//resto = resto % (nota * 100);

//nota = 5;
//quociente = resto / (nota * 100);
//Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//resto = resto % (nota * 100);

//nota = 2;
//quociente = resto / (nota * 100);
//Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
//resto = resto % (nota * 100);

//Console.WriteLine("MOEDAS:");


//moeda = 100;
//quociente = resto / moeda;
//Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
//resto = resto % moeda;

//moeda = 50;
//quociente = resto / moeda;
//Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
//resto = resto % moeda;

//moeda = 25;
//quociente = resto / moeda;
//Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
//resto = resto % moeda;

//moeda = 10;
//quociente = resto / moeda;
//Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
//resto = resto % moeda;

//moeda = 5;
//quociente = resto / moeda;
//Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
//resto = resto % moeda;

//Console.WriteLine(resto + " moeda(s) de R$ 0.01");

//int N, anos, meses, dias, resto;

//N = int.Parse(Console.ReadLine());

//anos = N / 365;
//resto = N % 365;
//meses = resto / 30;
//dias = resto % 30;

//Console.WriteLine(anos + " ano(s)");
//Console.WriteLine(meses + " mes(es)");
//Console.WriteLine(dias + " dia(s)");
//Console.ReadKey();



//int N, quociente, resto, nota;

//N = int.Parse(Console.ReadLine());
//Console.WriteLine(N);

//            resto = N;

//            nota = 100;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
//            resto = resto % nota;

//            nota = 50;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
//            resto = resto % nota;

//            nota = 20;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
//            resto = resto % nota;

//            nota = 10;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
//            resto = resto % nota;

//            nota = 5;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
//            resto = resto % nota;

//            nota = 2;
//            quociente = resto / nota;
//            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
//            resto = resto % nota;

//            Console.WriteLine(resto + " nota(s) de R$ 1,00");



//int n;
//n = int.Parse(Console.ReadLine());
//int horas = n / 3600;
//int resto = n % 3600;
//int minutos = resto / 60;
//int segundos = resto % 60;

//Console.WriteLine(horas+":"+minutos+":"+segundos);


//double x1, y1, x2, y2;
//double distancia;

//string[] vet = Console.ReadLine().Split(' ');
//x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
//y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

//vet = Console.ReadLine().Split(' ');
//x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
//y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

//distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

//            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

//int x, y, z, maiorXY, maior;

//string[] valores = Console.ReadLine().Split(' ');
//x = int.Parse(valores[0]);
//y = int.Parse(valores[1]);
//z = int.Parse(valores[2]);

//maiorXY = (x + y + Math.Abs(x - y)) / 2;

//maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

//Console.WriteLine(maior + " eh o maior");

//double A, B, C;
//double triangulo, circulo, trapezio, quadrado, retangulo;

//string[] valores = Console.ReadLine().Split(' ');
//A = double.Parse(valores[0], CultureInfo.InvariantCulture);
//B = double.Parse(valores[1], CultureInfo.InvariantCulture);
//C = double.Parse(valores[2], CultureInfo.InvariantCulture);

//triangulo = A * C / 2;
//circulo = 3.14159 * C * C;
//trapezio = (A + B) / 2.0 * C;
//quadrado = B * B;
//retangulo = A * B;

//Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
//Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
//Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
//Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
//Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

//double volume;
//double raio;
//double pi = 3.14159;
//raio = double.Parse(Console.ReadLine());

//volume = (4 / 3.0) * pi * Math.Pow(raio, 3.0);

//Console.WriteLine("VOLUME = "+volume.ToString("F3", CultureInfo.InvariantCulture));

//string Nome;
//double salario, totalVendas, salariototal;
//Nome = Console.ReadLine();
//salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//salariototal = totalVendas * 15.0 / 100 + salario;
//Console.WriteLine("TOTAL = R$ " + salariototal.ToString("F2", CultureInfo.InvariantCulture));

//int tempo, velocidade, distPerc;
//double litrosNec;

//tempo = int.Parse(Console.ReadLine());
//velocidade = int.Parse(Console.ReadLine());
//distPerc = tempo * velocidade;

//litrosNec = distPerc / 12.0;
//Console.WriteLine(litrosNec.ToString("F3", CultureInfo.InvariantCulture));
//Console.ReadLine();

//int distancia, tempo;
//distancia = int.Parse(Console.ReadLine());
//tempo = distancia * 2;
//Console.WriteLine(tempo + " minutos");

//int distancia;
//double combustivel, consumo;

//distancia = int.Parse(Console.ReadLine());
//combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//consumo = (double)distancia/combustivel;
//Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture)+ " km/l");
//Console.ReadKey();

//int cod1, cod2, qte1, qte2;
//double preco1, preco2, total;

//string[] valores = Console.ReadLine().Split(' ');
//cod1 = int.Parse(valores[0]);
//qte1 = int.Parse(valores[1]);
//preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

//valores = Console.ReadLine().Split(' ');
//cod2 = int.Parse(valores[0]);
//qte2 = int.Parse(valores[1]);
//preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

//total = preco1 * qte1 + preco2 * qte2;

//Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

//int _numeroFuncionario, _numeroDeHorasTrabalhadas;
//double _valorHoraTrabalhada, _valorSalario;

//_numeroFuncionario = int.Parse(Console.ReadLine());
//_numeroDeHorasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//_valorHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//_valorSalario = _numeroDeHorasTrabalhadas * _valorHoraTrabalhada;
//Console.WriteLine("NUMBER = " + _numeroFuncionario);
//Console.WriteLine("SALARY = U$ " + _valorSalario.ToString("F2", CultureInfo.InvariantCulture));

//int A, B, C, D, DIFERENCA;
//A = int.Parse(Console.ReadLine());
//B = int.Parse(Console.ReadLine());
//C = int.Parse(Console.ReadLine());
//D = int.Parse(Console.ReadLine());

//DIFERENCA = ((A* B) - (C* D));
//            Console.WriteLine("DIFERENCA = " + DIFERENCA);

//int A, B, PROD;
//A = int.Parse(Console.ReadLine());
//B = int.Parse(Console.ReadLine());
//PROD = A * B;
//Console.WriteLine("PROD = " + PROD);

//int A, B, SOMA;
//A = int.Parse(Console.ReadLine());
//B = int.Parse(Console.ReadLine());
//SOMA = A + B;
//Console.WriteLine("SOMA = " + SOMA);

//double _area;
//double n = 3.14159;
//double raio;
//raio = Math.Pow(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), 2.0);
//_area = n * raio;
//Console.WriteLine("A=" + _area.ToString("F4", CultureInfo.InvariantCulture));


//int A, B, X;
//A = int.Parse(Console.ReadLine());
//B = int.Parse(Console.ReadLine());
//X = A + B;
//            Console.WriteLine("X = " + X);


//double x, y, media;
// The code provided will print ‘Hello World’ to the console.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.



//Console.WriteLine("digite um numero");
//x = double.Parse(Console.ReadLine());
//Console.WriteLine("digite o segundo numero");
//y = double.Parse(Console.ReadLine());
//media = (x + y) / 2.0;
//Console.WriteLine("o Seu resultado e :" + media);

//double b, B, h, area;
//b = 6.0;
//B = 8.0;
//h = 5.0;
//area = (b + B) / 2.0 * h;


//float a, b;
//double resultado;
//a = 5;
//b = 2;
//resultado = a / b;

//x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//double b, a, c;
//b = 3;
//a = 5;
//c = 43;
//double delta = Math.Pow(b, 2.0) - 4 * a * c;


//double _largura;
//double _comprimento;
//double _valorDoMetroQuadrado;
//double _valorDaAreaDoTerreno;
//double _valorDoPreçoDoTerreno;

//Console.WriteLine("Digite a Largura do Terreno: ");
//_largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine("Digite o Comprimento do Terreno: ");
//_comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine("Digite o Valor do Metro Quadrado do Terreno: ");
//_valorDoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//_valorDaAreaDoTerreno = _largura * _comprimento;
//_valorDoPreçoDoTerreno = _valorDoMetroQuadrado * _valorDaAreaDoTerreno;

//Console.WriteLine("O terreno tem " + _valorDaAreaDoTerreno.ToString("F2", CultureInfo.InvariantCulture) + "M² e tem um custo total de R$: " + _valorDoPreçoDoTerreno.ToString("F2", CultureInfo.InvariantCulture));
