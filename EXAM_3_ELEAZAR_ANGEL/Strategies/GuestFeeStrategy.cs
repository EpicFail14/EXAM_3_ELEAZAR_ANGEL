using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Strategies
{
    public class GuestFeeStrategy : ILateFeeStrategy
    {
        public double CalculateFee(int days)
        {
            return days * 3.0; // higher penalty
        }
    }
}
