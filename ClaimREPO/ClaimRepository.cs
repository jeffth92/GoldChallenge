using Claim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimREPO
{
    public class ClaimRepository
    {
        private Queue<Claim.Claim> _queueOfClaims = new Queue<Claim.Claim>();
        public void AddClaimToQueue(Claim.Claim claim) //create
        {
            _queueOfClaims.Enqueue(claim);
        }
        public Queue<Claim.Claim> GetClaimQueue() //read all
        {
            return _queueOfClaims;
        }
        public Claim.Claim PeekNextClaim() // read one
        {
            return _queueOfClaims.Peek();
        }
        public Claim.Claim DequeueClaim() //delete
        {
            return _queueOfClaims.Dequeue();
        }
    }
}
