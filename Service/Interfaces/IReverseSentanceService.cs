using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IReverseSentanceService
    {
        public string GenerateReverseString(string sentance)
        {
            string TempString = "";
            string ReversedString = "";
            for (int i = 0; i < sentance.Length; i++)
            {
                if (sentance[i] != ' ') TempString += sentance[i];
                else if (TempString != "")
                {
                    ReversedString = (ReversedString == "") ? TempString + ReversedString : TempString + " " + ReversedString;
                    TempString = "";
                }

                if (i == sentance.Length - 1)
                {
                    if (ReversedString == "") ReversedString = TempString + ReversedString;
                    else if (TempString != "") ReversedString = TempString + " " + ReversedString;
                }
            }

            return ReversedString;
        }
    }
}
