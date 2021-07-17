﻿using Claim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimREPO
{
    public class ClaimRepository
    {
        private List<Claim.Claim> _ListOfClaims = new List<Claim.Claim>();
        public void AddClaimToList(Claim.Claim claim) //create
        {
            _ListOfClaims.Add(claim);
        }
        public List<Claim.Claim> GetClaimList() //read
        {
            return _ListOfClaims;
        }
    }
}
