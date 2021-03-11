using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidJournal.Models;

namespace CovidJournal.Methods
{
    public static class LinqSymptoms
    {
        public static string SymptomsList(CovidEntry covidEntry)
        {
            string symptoms = "";
            foreach (var prop in covidEntry.GetType().GetProperties())
            {
                // type is the data type
                var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                if (type == typeof(bool))
                {
                    if ((bool)prop.GetValue(covidEntry, null) == true)
                    {
                        symptoms += prop.Name + ", ";
                    }
                }
            }
            if (symptoms.Length == 0)
            {
                return "No symptoms";
            }

            return symptoms.Remove(symptoms.Length - 2, 2).Replace("_", " ");
        }
    }
}