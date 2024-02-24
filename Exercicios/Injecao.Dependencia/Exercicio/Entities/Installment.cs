using System.Globalization;

namespace Interfaces.Exercicio.Entities
{
    class Installment
    {
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            Amount = amount;
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
