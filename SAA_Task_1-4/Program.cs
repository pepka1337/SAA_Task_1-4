// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Ввод начального количества золота у пользователя
        Console.Write("Введите кол-во золота, которое вы хотите: ");
        int Gold = Convert.ToInt32(Console.ReadLine());

        // Ввод цены одного кристалла и количества кристаллов для покупки
        Console.Write("Введите цену одного кристалла: ");
        int Price = Convert.ToInt32(Console.ReadLine());

        Console.Write("Сколько кристаллов вы хотите купить? ");
        int Diamond = Convert.ToInt32(Console.ReadLine());

        // Проверка на достаточность золота для покупки кристаллов
        int remainingGold = Gold - (Diamond * Price);
        int enoughGold = Convert.ToInt32(Math.Ceiling((double)remainingGold / Gold));

        // Вывод результата
        Console.WriteLine(enoughGold == 1 ? $"Вы купили {Diamond} кристаллов. У вас осталось {remainingGold} золота." : "Недостаточно золота для покупки указанного количества кристаллов.");
    }
}