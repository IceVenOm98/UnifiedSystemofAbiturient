using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class ApplicationCreator
    {
        public ApplicatioN createApplication(University university, User user, Subjects[] subjects)
        {
            ApplicatioN applicatioN = new ApplicatioN(university, user, subjects);
            createReport(applicatioN);
            return applicatioN;

        }
        private void createReport(ApplicatioN applicatioN)
        {
            //TODO отправка отчета куда надо
        }
    }
}