using System;

namespace pz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] inv = { new Invoice("Олег", "23.10-23.11","Чкалова 4"), new Invoice("0123456789", 2307, "01.01-02.02"), new Invoice(9817238, "Чкалова 7"), new Invoice() };
            for (int i = 0; i < inv.Length; i++)
            {
                Console.WriteLine("\n"+"Следующий клиент:");
                inv[i].GetInvoiceInf();
            }
            Console.WriteLine("Количество указаныых счетов:"+Invoice.GetCounter()+"Сумма всех счетов:"+Invoice.GetSummAllInvoice());//вывод результата статических полей
        }
    }
    class Invoice
    {
        string period;
        string clientName;
        string codeOfInvoice;
        int summ;
        string adr;
        static int counter;
        static int summ_Invoices;
        public Invoice(string clientName, string period,string adr)
        {
            if (clientName != null) this.clientName = clientName;//проверка на не пустоту имени клиента
            else this.clientName = "пусто";
            if (period != null) this.period = period;//проверка на не пустоту периода
            else this.period = "пусто";
            codeOfInvoice = "0000000000";
            summ = 0;
            if (adr != null) this.adr = adr;//проверка на не пустотоу адреса
            else this.adr = "пусто";
            counter++;
            summ_Invoices += summ;
        }
        public Invoice(string codeOfInvoice, int summ, string period)
        {
            int code = 0;
            if (int.TryParse(codeOfInvoice, out code) && codeOfInvoice.Length == 10) this.codeOfInvoice = codeOfInvoice;
            else this.codeOfInvoice = "пусто";
            if (summ >= 0 && summ <= 10000) this.summ = summ;//проверка корректности суммы
            else this.summ = -1;
            clientName = "Неизвестный";
            adr = "бездомный";
            if (period != null) this.period = period;//проверка на не пустоту периода
            else this.period = "пусто";
            counter++;
            summ_Invoices += summ;
        }
        public Invoice(int summ, string adr)
        {
            if (summ >= 0 && summ <= 10000) this.summ = summ;//проверка корректности суммы
            else this.summ = -1;
            if (adr != null) this.adr = adr;//проверка на не пустотоу адреса
            else this.adr = "пусто";
            clientName = "???";
            period = "прошлый месяц-текущий месяц";
            codeOfInvoice = "8712736412";
            counter++;
            summ_Invoices += summ;

        }
        public Invoice()
        {
            this.adr = this.period = this.clientName = this.codeOfInvoice = "неизвестно";
            summ = 0;
            counter++;
            summ_Invoices += summ;
        }
        public void GetInvoiceInf()
        {
            Console.WriteLine("период: " + period + '\n' + "имя клиента: " + clientName + '\n' + "код счета: " + codeOfInvoice + '\n' + "сумма к оплате: " + summ + '\n' + "адрес: " + adr);
        }
        public static int GetCounter()//статическое поле подсчитывающее количество счетов
        {
            return counter;
        }
        public static int GetSummAllInvoice()//статическое поле подсчитываюшее сумму всех счетов
        {
            return summ_Invoices;
        }
    }
}
