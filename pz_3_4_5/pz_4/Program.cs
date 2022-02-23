using System;

namespace pz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] inv = { new Invoice("Олег", "23.10-23.11", "Чкалова 4"), new Invoice("0123456789", 2307, "01.01-02.02"), new Invoice(981, "Чкалова 7"), new Invoice() };
            OverdueInvoice[] odi = { new OverdueInvoice("Петр", "23.10-23.11", "Чкалова 7", new DateTime(2022, 02, 17), new DateTime(2022, 01, 17)), new OverdueInvoice("0123456789", 2307, "01.01-02.02", new DateTime(2022, 02, 17), new DateTime(2022, 01, 17)), new OverdueInvoice(9817, "Чкалова 7"), new OverdueInvoice() };
            for (int i = 0; i < inv.Length; i++)
            {
                Console.WriteLine("\n" + "Следующий клиент:");
                inv[i].GetInvoiceInf();
            }
            for (int i = 0; i < odi.Length; i++)
            {
                Console.WriteLine('\n' + "Следующий клиент: ");
                odi[i].GetInvoiceInf();
                Console.WriteLine("Сумма просроченного платежа " + odi[i].GetOverdueAmount());//просроченный будет только у тех у кого указанна сумма
            }
            Console.WriteLine("\nКоличество указаныых счетов:" + Invoice.GetCounter() + '\n' + "Сумма всех счетов:" + Invoice.GetSummAllInvoice());//вывод результата статических полей
        }
    }
    
}
