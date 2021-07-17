using ClaimREPO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClaimsTEST
{
    [TestClass]
    public class ClaimsTesting
    {
        [TestMethod]
        public void AddClaimToQueue_Doesnt_Return_Null() //create
        {
            //arrange
            ClaimRepository repo = new ClaimRepository();
            Claim.Claim claim = new Claim.Claim(1, "theft", "cheese", 2.00m, new DateTime(2021/12/12), new DateTime(2021/12/12), true);
            repo.AddClaimToQueue(claim);
            //act
            var testitem = claim;
            //assert
            Assert.IsNotNull(testitem);
        }
        [TestMethod]
        public void GetClaimQueue_Doesnt_Return_Null() //read all
        {
            ClaimRepository repo = new ClaimRepository();
            var test = repo.GetClaimQueue();
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void PeekNextClaim_Returns_Claim() //read one
        {
            ClaimRepository repo = new ClaimRepository();
            Claim.Claim claim = new Claim.Claim(1, "theft", "cheese", 2.00m, new DateTime(2021 / 12 / 12), new DateTime(2021 / 12 / 12), true);
            repo.AddClaimToQueue(claim);
            //act
            var test = claim;
            var testpeek = repo.PeekNextClaim();
            //assert
            Assert.AreEqual(test, testpeek);
        }
        [TestMethod]
        public void DeQueueClaim_Returns_Claim_As_Empty() //delete
        {
            ClaimRepository repo = new ClaimRepository();
            Claim.Claim claim = new Claim.Claim(1, "theft", "cheese", 2.00m, new DateTime(2021 / 12 / 12), new DateTime(2021 / 12 / 12), true);
            repo.AddClaimToQueue(claim);
            repo.DequeueClaim();
            var testitem = repo.GetClaimQueue();
            Assert.AreEqual(testitem.Count, 0);
        }
    }
}
