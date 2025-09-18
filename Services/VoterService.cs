using School_Election_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Election_System.Repositories
{
    internal class VoterService
    {
        private VoterRepository repository = new VoterRepository();


        public void SaveVoter(VoterModel voter)
        {
            repository.Save(voter);
        }
    }
}
