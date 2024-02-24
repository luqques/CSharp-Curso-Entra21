using Interfaces.Exercicio.Entities;

namespace Interfaces.Exercicio.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 0; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);

                double updatedQuota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.PaymentFee(updatedQuota);

                contract.AddIntallments(new Installment(date, fullQuota));
            }
        }
    }
}
