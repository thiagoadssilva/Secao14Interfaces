using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFixation.Entities
{
    class Contract
    {
        public int Number{ get; set; }
        public DateTime Date{ get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int numberContrac, DateTime dateContract, double valueContrac)
        {
            Number = numberContrac;
            Date = dateContract;
            TotalValue = valueContrac;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
