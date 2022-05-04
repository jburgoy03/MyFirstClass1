using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass1 //namespace
{
    internal class TQLStudent  //class
    {
        public string FirstName { get; set; } = string.Empty; //properties
        public string LastName { get; set; } = string.Empty ;
        public int YearsOfService { get; set; } = 0 ;
        public Assessment? GitGithubAssessment { get; set; } = null;
        public Assessment? SQLAssessment { get; set; } = null;
        public Assessment? CSharp{ get; set; } = null;
        public Assessment? Angular { get; set; } = null;
        public Assessment? Java { get; set; } = null;
       
       
        public string FullName() {
            return $"{this.FirstName} {this.LastName}"; //methods
        }

        public string Print()
        {
            var msg = $"{FullName()} has {YearsOfService} year{(YearsOfService > 1 ? "s" : "")} of service at TQL.";
            if(GitGithubAssessment is not null)
            {
                msg = msg + $"\nAssessment {GitGithubAssessment!.Topic}, Points: {GitGithubAssessment.Points}";
            }
            if (SQLAssessment is not null)
            {
                msg = msg + $"\nAssessment {SQLAssessment!.Topic}, Points: {SQLAssessment.Points}";
            }
            if(CSharp is not null)
            {
                msg = msg + $"\nAssessment {CSharp!.Topic}, Points: {CSharp.Points}";
            }
            if (Angular is not null)
            {
                msg = msg + $"\nAssessment {Angular!.Topic}, Points: {Angular.Points}";
            }
            if (Java is not null)
            {
                msg = msg + $"\nAssessment {Java!.Topic}, Points: {Java.Points}";
            }
            return msg;

        }
        public void HappyAnniversary() 
        {
            YearsOfService++;
        }
        
        public TQLStudent (string firstname, string lastname, int YearsOfService) { 
            FirstName = firstname; LastName = lastname; this.YearsOfService = YearsOfService; //constructors
        }
        public TQLStudent() {}
    }
}
