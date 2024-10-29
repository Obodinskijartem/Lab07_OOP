﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_OOP
{
    internal interface ISubscriberInfo
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        int CallMinutesPerMonth { get; set; }
        int SMSPerMonth { get; set; }
        double MonthlyFee { get; set; }
        bool HasRoaming { get; set; }
        bool HasDataPlan { get; set; }

        int CompareTo(Subscriber other);
    }
}
