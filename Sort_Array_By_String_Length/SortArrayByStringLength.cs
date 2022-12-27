using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array_By_String_Length;

public class SortArrayByStringLength
{
    public static string[] SortByLength(string[] array)
    {
        string temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i].Length > array[j].Length)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }
}
