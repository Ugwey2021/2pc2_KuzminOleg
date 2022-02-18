using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_4
{
    class OverdueInvoice : Invoice
    {
        DateTime EndDay = DateTime.Now;
        DateTime DueDate = new DateTime(2022, 02, 17);//дата начала просрочки
        public override void GetInvoiceInf()
        {
            Console.WriteLine("период: " + period + '\n' + "имя клиента: " + clientName + '\n' + "код счета: " + codeOfInvoice + '\n' + "сумма к оплате: " + summ + '\n' + "адрес: " + adr + '\n' + "дата начала просрочки:" + DueDate);
        }
        public OverdueInvoice(string clientName, string period, string adr, DateTime EndDay, DateTime DueDate) : base(clientName, period, adr)
        {

            codeOfInvoice = "0000000000";
            summ = 0;

            this.EndDay = EndDay;
            this.DueDate = DueDate;
        }
        public OverdueInvoice(int summ, string adr) : base(summ, adr)
        {

            clientName = "???";
            period = "прошлый месяц-текущий месяц";
            codeOfInvoice = "8712736412";

        }
        public OverdueInvoice(string codeOfInvoice, int summ, string period, DateTime EndDay, DateTime DueDate) : base(codeOfInvoice, summ, period)
        {
            this.EndDay = EndDay;
            this.DueDate = DueDate;
            clientName = "Неизвестный";
            adr = "бездомный";

        }
        public OverdueInvoice()
        {
            this.adr = this.period = this.clientName = this.codeOfInvoice = "неизвестно";
            summ = 0;
        }
        public int GetOverdueAmount()
        {
            //Console.WriteLine((EndDay.Year - DueDate.Year) * 365 + (EndDay.Month - DueDate.Month) * 30 + (EndDay.Day - DueDate.Day));
            return ((EndDay.Year - DueDate.Year) * 365 + (EndDay.Month - DueDate.Month) * 30 + (EndDay.Day - DueDate.Day)) * summ / 100;
        }
    }
}
