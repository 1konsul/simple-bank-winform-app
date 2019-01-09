using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Guy
    {
        public int Money { get; set; }
        public void BorrowCash(int amount)
        {
            Money += amount;
        }
        public void LendCash(int amount)
        {
            Money -= amount;
        }
        public Guy() { }
        public Guy(int money)
        {
            this.Money = money;
        }

    }
}
