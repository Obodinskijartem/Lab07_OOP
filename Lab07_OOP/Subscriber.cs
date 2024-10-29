using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_OOP
{
    public class Subscriber : IComparable<Subscriber>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CallMinutesPerMonth { get; set; }
        public int SMSPerMonth { get; set; }
        public double MonthlyFee { get; set; }
        public bool HasRoaming { get; set; }
        public bool HasDataPlan { get; set; }

        public Subscriber(string name, string phoneNumber, string address, int callMinutesPerMonth,
                         int smsPerMonth, double monthlyFee, bool hasRoaming, bool hasDataPlan)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            CallMinutesPerMonth = callMinutesPerMonth;
            SMSPerMonth = smsPerMonth;
            MonthlyFee = monthlyFee;
            HasRoaming = hasRoaming;
            HasDataPlan = hasDataPlan;
        }

        public override string ToString()
        {
            return $"{Name}, {PhoneNumber}, {Address}, {CallMinutesPerMonth} хвилин, {SMSPerMonth} SMS, {MonthlyFee} грн.";
        }
        public int CompareTo(Subscriber? other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
    }
}