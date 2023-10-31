using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8PatientInfo
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set;}
        public DateTime DoB { get; set; }
        public bool Gender { get; set; }
        public string Income { get; set; }
        public string BMI { get; set; }
        public Patient(int patientId, string patientName, DateTime doB, bool gender, string income, string bMI)
        {
            PatientId = patientId;
            PatientName = patientName;
            DoB = doB;
            Gender = gender;
            Income = income;
            BMI = bMI;
        }
    }
}
