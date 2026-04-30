using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Strategies
{
    public interface ILateFeeStrategy
    {
        double CalculateFee(int days);
    }
}
