using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class SelectionByRait:Selection
    {
        public override List<University> get(List<University> universities)
        {
            University[] array = universities.ToArray();
            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                University buffer = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j].getAveragePoint() < buffer.getAveragePoint())
                        break;
                    array[j + 1] = array[j];
                }
                array[j + 1] = buffer;
            }
            List<University> universities1 = new List<University>(array);
            return universities1;
        }
    }
}