// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа. 
//Вычислить сумму цифр введенного числа
string s = Console.ReadLine();
int sum = 0;
bool temp = true;
for (int i = 0; i < s.Length; i++)
{
    if(char.IsDigit(s[i])) 
        sum+=Convert.ToInt32(s[i].ToString());
    else if(i == 0 && s[i] == '-') continue;
    else {
        temp = false;
        break;
    }
}
if(temp) 
    Console.WriteLine($"Сумма цифр числа {s} равна: {sum}");
else 
    System.Console.WriteLine("Введенное число не является правильной записью целого числа");