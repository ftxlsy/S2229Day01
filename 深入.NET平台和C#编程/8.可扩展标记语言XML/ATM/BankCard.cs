using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class BankCard
    {
        private string cardID;

        public string CardID
        {
            get { return cardID; }
            set { cardID = value; }
        }
        private string cardPwd;

        public string CardPwd
        {
            get { return cardPwd; }
            set { cardPwd = value; }
        }
        private string cardName;

        public string CardName
        {
            get { return cardName; }
            set { cardName = value; }
        }
        private double cardMoney;

        public double CardMoney
        {
            get { return cardMoney; }
            set { cardMoney = value; }
        }
        public virtual double Draw(double mon)
        {
            double money = CardMoney - mon;
            return money;
        }
    }
}
