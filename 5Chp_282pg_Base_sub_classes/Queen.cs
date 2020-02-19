using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Chp_282pg_Base_sub_classes
{
    class Queen:Bee
    {
        private Worker[] workers;
        private int shiftNumber;

       public bool AssignWork(string JobToBeDone, int HowManyShifts)
        {
            for (int i = 0; i < 4; i++) if (workers[i].DoThisJob(JobToBeDone, HowManyShifts)) return true;
            return false;
        }

        public bool WorkTheNextShift(int i)
        {
            shiftNumber++;
            if (workers[i].DidYouFinish()) return true;
            else return false;          
        }

        public Queen(int shiftnumber, Worker[] workers, double weightMg):base(weightMg)
        {
            this.workers = workers;
            this.shiftNumber = shiftnumber;
        }
    }
}
