using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Strategies
{
    public class StudentFeeStrategy : ILateFeeStrategy
    {
        public double CalculateFee(int days) => days * 2.0;
    }
}
