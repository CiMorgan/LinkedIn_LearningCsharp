using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    interface IPayee
    {
        void Pay();
    } 
    class Payroll
    {
        List<IPayee> payees = new List<IPayee>();
        public Payroll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
    }
}
