using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска
        private int magazineVolume;
        private int magazineNumber;
        private string magazineTitle;
        private int magazineYear;
        private int magazineInvNumber;
        private bool magazineExistence;

        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public Magazine(int magazineVolume, int magazineNumber, string magazineTitle, int magazineYear, int magazineInvNumber, bool magazineExistence)
        {
            this.magazineVolume = magazineVolume;
            this.magazineNumber = magazineNumber;
            this.magazineTitle = magazineTitle;
            this.magazineYear = magazineYear;
            this.magazineInvNumber = magazineInvNumber;
            this.magazineExistence = magazineExistence;
        }

        public override void Return()    // операция "вернуть"
       {
           taken = true;
       }

        // реализация интерфейса

      

      public void Subs()
      {
          // действия при оформлении подписки на журнал
      }


       public override string ToString()
       {
           if (IfSubs)
           return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
           else
               return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
           "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
       }
    }
}
