using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            int sum = 0;
            // add logic to calculate the average
           foreach(int sumtemp in _temperatures)
            {
               sum += sumtemp ; 
            }
            return sum / _temperatures.Count; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            int abtn = 0;
            // add logic to calculate temps above the threshold
            foreach (int abovetemp in _temperatures)
            {
                
                if (abovetemp>threshold)
                {
                    abtn++;
                }
            }
            return abtn; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int btn = 0;
           
            foreach (int bellowtemp in _temperatures)
            {

                if (bellowtemp < threshold)
                {
                    btn++;
                }
            }
            return btn; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int at = 0;
            foreach (int attemp in _temperatures)
            {

                if (attemp == threshold)
                {
                    at++;
                }
            }
            return at; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
