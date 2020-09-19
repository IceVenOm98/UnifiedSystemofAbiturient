using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class ApplicationCreator
    {
        public ApplicatioN createApplication(University university, Abiturient abiturient, Subjects[] subjects)
        {
            ApplicatioN applicatioN = new ApplicatioN(university, abiturient, subjects);
            createReport(applicatioN);
            return applicatioN;

        }
        private void createReport(ApplicatioN applicatioN)
        {
            //TODO отправка отчета куда надо
        }
    }
}