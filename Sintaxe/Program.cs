using Sintaxe.Models;

Person person = new Person();

person.Name = "Brenndha";
person.Age = 28;
person.Height = 1.78; // eu posso passar um número inteiro também pois o double irá aceitar
person.Money = 2500.00M; // preciso colocar o M no final para ele entender que estou passando um valor monetário de fato
person.today = DateTime.Now;
person.Work = true;

person.Presentation();
