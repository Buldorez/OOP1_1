using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokupatel pokupatel = new Pokupatel();
            pokupatel.pokupatelSurname = "Ромащенко";
            pokupatel.pokupatelName = "Анна";
            pokupatel.pokupatelPatronim = "Владимировна";
            pokupatel.pokupatelAdress = "Г Екатеринбург, Ул. Мичурина 11";
            pokupatel.cardGet("2200 2200 1300 1400");
            pokupatel.bankGet("187");
            pokupatel.outText();
            Console.ReadLine();
        }
        class Pokupatel
        {
            public void outText()
            {
                Console.WriteLine($" Фамилия: {pokupatelSurname}");
                Console.WriteLine($" Имя: {pokupatelName}");
                Console.WriteLine($" Отчество: {pokupatelPatronim}");
                Console.WriteLine($" Адрес: {pokupatelAdress}");
                Console.WriteLine($" Номер карты: {pokupatelCardNumber}");
                Console.WriteLine($" Банковский счёт: {pokupatelBankNumber}");
            }
            public void cardGet(string number)
            {
                pokupatelCardNumber = number;
            }
            public void bankGet(string number)
            {
                pokupatelBankNumber = number;
            }
            public string pokupatelSurname;
            public string pokupatelName;
            public string pokupatelPatronim;
            public string pokupatelAdress;
            private string pokupatelCardNumber;
            private string pokupatelBankNumber;
        }
    }
}
