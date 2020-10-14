using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;

namespace TestingArea
{
    public class Testing
    {

        public static void Main()
        {

        }
            // keeps track of the internal count of items in the array list
            private int count = 0;
            // stores the values in the array list
            private string[] vals = new string[50];

            /// <summary>
            /// Inserts an item into the array list and shifts the existing 
            /// item (if any) at that index and all subsequent items forward 
            /// by one index (their index increases by 1). 
            /// 
            /// If count is equal to the capacity of vals (before inserting) 
            /// throws InvalidOperationException.
            ///
            /// If index is less than 0 or greater than count,
            /// throws ArgumentException.
            /// </summary>
            /// <param name="item">The item to be inserted</param>
            /// <param name="index">The index at which to insert</param>
            public void Insert(string item, int index)
            {
                if (count == vals.Length)
                    return;
                if (index > count)
                    throw new ArgumentException();
                vals[index] = item;
                count++;
            }

            /// <summary>
            /// Returns the item at the specified index.
            /// If the index is out of range, throws ArgumentException.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public string Get(int index)
            {
                if (index < 0 || index >= count)
                    throw new ArgumentException();
                return vals[index];
            }

    }
}

