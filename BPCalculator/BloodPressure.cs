using System;
using System.ComponentModel.DataAnnotations;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name="Low Blood Pressure")] Low,
        [Display(Name="Ideal Blood Pressure")]  Ideal,
        [Display(Name="Pre-High Blood Pressure")] PreHigh,
        [Display(Name ="High Blood Pressure")]  High,

    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG
      
        
        // calculate BP category
        public BPCategory Category
        {
            get
            {
                if ((Systolic >= 70.0 && Systolic < 90.0) && (Diastolic >= 40.0 && Diastolic < 60.0))
                { return BPCategory.Low; }

                else if ((Systolic >= 90 && Systolic <= 120.0) && (Diastolic >= 70 && Diastolic <= 80.0))
                { return BPCategory.Ideal; }

                else if ((Systolic >= 120 && Systolic <= 140.0) && (Diastolic >= 80 && Diastolic <= 90.0))
                { return BPCategory.PreHigh; }

                else if ((Systolic >= 140 && Systolic <= 190.0) && (Diastolic >= 90 && Diastolic <= 100.0))
                { return BPCategory.High; }

                else
                { throw new NotImplementedException("Incorrect Range"); }
            }
        }
    }
}
