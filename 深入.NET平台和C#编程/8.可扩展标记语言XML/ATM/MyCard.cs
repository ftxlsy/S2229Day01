using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
   public class MyCard:BankCard
    {
          public MyCard() { }
          public MyCard(string cardID, string cardPwd, string cardName, double cardMoney)
       {
           this.CardID = cardID;
           this.CardPwd = cardPwd;
           this.CardName = cardName;
           this.CardMoney = cardMoney;
       }
       public override double Draw(double mon)
       {
           double money = this.CardMoney - mon;
           return money;
       }
    }
}
