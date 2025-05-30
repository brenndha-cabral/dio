// See https://aka.ms/new-console-template for more information

int number1 = Convert.ToInt32("5"); // aceita valor null = retorna 0, mais usual para não quebrar a aplicação
int number2 = int.Parse("5"); // não aceita o valor null
int number3 = 5;
double number4 = number3;
long number5 = number3;
string value1 = number3.ToString();

Console.WriteLine($"{number1}, {number2}, {number3}, {number4}, {number5}, {value1}");
