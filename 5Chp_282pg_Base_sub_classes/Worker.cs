using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Chp_282pg_Base_sub_classes
{
    class Worker:Bee
    {
        private string currentJob;
        private int shiftsLeft; 

        public string CurrentJob { get { return currentJob; } }
        public int ShiftsLeft { get { return shiftsLeft; } }
      

        private string [] jobsIcanDo;

        public bool DoThisJob(string jobToDo, int HowManyShifts)
        {
            if (CurrentJob == null)
            {
                for (int i = 0; i < jobsIcanDo.Length; i++)
                {
                    if (jobToDo == jobsIcanDo[i])
                    {
                        currentJob = jobToDo;
                        shiftsLeft = HowManyShifts;
                        return true;
                    } 
                }  
            }
            return false;        
        }

        public bool DidYouFinish()
        {
            shiftsLeft--;

            if (ShiftsLeft < 1)
            {
                currentJob = null;
                shiftsLeft = 0;
                return true;
            }
            else return false;        
        }

        public Worker(string[] jobsIDo, double weightMg):base(weightMg)
        {
            this.jobsIcanDo = jobsIDo;
        }

        public override double HoneyConsumptionRate()
        {
            if (currentJob != null) return base.HoneyConsumptionRate();
            else return base.HoneyConsumptionRate() + .65;
        }
    }
}
