using Claim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimREPO
{
    public class ClaimRepository // See all claims, Take Care of next claim, Enter a new claim
    {
        private List<Claim.Claim> _ListOfClaims = new List<Claim.Claim>();
        public void AddClaimToList(Claim.Claim claim)
        {
            _ListOfClaims.Add(claim);
        }
        public List<Claim.Claim> GetClaimList()
        {
            return _ListOfClaims;
        }
        //next claim? Research needed of Queues
    }
}
