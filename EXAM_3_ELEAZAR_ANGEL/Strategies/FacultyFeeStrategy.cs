using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Strategies
{
    public class FacultyFeeStrategy : ILateFeeStrategy
    {
        public double CalculateFee(int days) => days * 0.5;
    }
}
