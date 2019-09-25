using System;
using System.Text.RegularExpressions;

// SOLVED
namespace CountingValleys
{
    public class CountValleys
    {
        // Trackers
        private int currentLevel;
        private bool hasNotSurfaced;
        private int valleysTraversed;

        public CountValleys()
        {
            currentLevel = 0;
            valleysTraversed = 0;
            hasNotSurfaced = false;
        }

        public int countingValleys(int n, string s)
        {
            // Copy the given string path so we can loop through it
            char[] path = new char[s.Length];
            s.CopyTo(0, path, 0, s.Length - 1);
      
            foreach(char hill in path)
            {
                // Going up
                if(hill.Equals('U'))
                {
                    currentLevel++;
                    
                    // Keep track of whether or not we have went below sea level and then resurfaced
                    if(currentLevel == 0 && hasNotSurfaced)
                    {
                        hasNotSurfaced = false;
                    }
                }
                // Going down
                else if (hill.Equals('D'))
                {
                    currentLevel--;

                    // We will only count a valley if we are going below sea level FROM above or at sea level
                    if(currentLevel < 0 && !hasNotSurfaced)
                    {
                        valleysTraversed++;
                        hasNotSurfaced = true;
                    }                  
                }
            }

            return valleysTraversed;
        }

    }
}
