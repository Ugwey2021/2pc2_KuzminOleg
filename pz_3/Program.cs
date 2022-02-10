using System;

namespace pz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] inv = { new Invoice("Олег", "23.10-23.11"), new Invoice("0123456789", 2307, "01.01-02.02"), new Invoice(9817238, "Чкалова 7"),new Invoice()};
            for (int i = 0; i < inv.Length; i++)
            {
                Console.WriteLine('\n' + "Следующий клиент" + '\n');
                inv[i].GetInvoiceInf();
                
            }

        }
    }
    class Invoice
    {
        string period;
        string clientName;
        string codeOfInvoice;
        int summ;
        string adr;
        public Invoice(string clientName,string period)
        {
            this.clientName = clientName;
            this.period = period;
            codeOfInvoice = "0000000000";
            summ = 0;
            adr = "улица Пушкина ,дом Колотушкина";
        }
        public Invoice(string codeOfInvoice,int summ,string period)
        {
            this.codeOfInvoice = codeOfInvoice;
            this.summ = summ;
            clientName = "Неизвестный";
            adr = "бездомный";
            this.period = period;
        }
        public Invoice(int summ,string adr)
        {
            this.summ = summ;
            this.adr = adr;
            clientName = "???";
            period = "прошлый месяц-текущий месяц";
            codeOfInvoice = "8712736412";

        }
        public Invoice()
        {
            this.adr = this.period = this.clientName = this.codeOfInvoice = "неизвестно";
            summ = 0;
        }
        public void GetInvoiceInf()
        {
            Console.WriteLine("период: "+period+'\n'+"имя клиента: "+clientName+ '\n'+"код счета: " +codeOfInvoice+ '\n'+"сумма к оплате: " +summ+ '\n'+"адрес: " +adr);
        }
    }
}
