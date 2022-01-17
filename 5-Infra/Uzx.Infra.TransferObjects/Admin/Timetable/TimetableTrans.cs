using System;
using System.Collections.Generic;
using Uzx.Infra.TransferObjects._Base;


namespace Uzx.Infra.TransferObjects.Admin
{
    public  class TimetableTrans :BaseTrans 
    {
        public Guid TimetableId { get; set; }

        public Guid CustomerId { get; set; }

        public bool hrs24 { get; set; }
        public bool AllDays { get; set; }
        public string AllDaysIn { get; set; }
        public string AllDaysOut { get; set; }
        public bool Monday { get; set; }
        public string MondayIn { get; set; }
        public string MondayOut { get; set; }
        public bool Tuesday { get; set; }
        public string TuesdayIn { get; set; }
        public string TuesdayOut { get; set; }
        public bool Wednesday { get; set; }
        public string WednesdayIn { get; set; }
        public string WednesdayOut { get; set; }
        public bool Thursday { get; set; }
        public string ThursdayIn { get; set; }
        public string ThursdayOut { get; set; }
        public bool Friday { get; set; }
        public string FridayIn { get; set; }
        public string FridayOut { get; set; }
        public bool Saturday { get; set; }
        public string SaturdayIn { get; set; }
        public string SaturdayOut { get; set; }
        public string Sunday { get; set; }
        public string SundayIn { get; set; }
        public string SundayOut { get; set; }

    }
}
