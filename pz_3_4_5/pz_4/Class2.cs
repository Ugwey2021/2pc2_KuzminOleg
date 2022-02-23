using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_4
{
    class Invoice
    {
        public string period { get; set; }
        public string clientName { get; set; }
        public string codeOfInvoice { get; set; }
        public int summ { get; set; }
        public string adr { get; set; }
        static int counter;
        static int summ_Invoices;
        public Invoice(string clientName, string period, string adr)
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
        public virtual void GetInvoiceInf()
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
