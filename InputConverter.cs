﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorCsharpCourse
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput) {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) {
                throw new ArgumentException("This input is not numeric.");
            }
            return convertedNumber;
        }
    }
}
