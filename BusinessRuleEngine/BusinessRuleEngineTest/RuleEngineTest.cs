using BusinessRuleEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineTest
{
    [TestClass]
    public class RuleEngineTest
    {
        [TestMethod]
        public void CheckRuleAddition()
        {
            RulesEngine ruleEngine = new RulesEngine("newOrder");
            ruleEngine.AddRule("payment", "make payment;send email");
            Assert.AreEqual("newOrder-payment-make payment;send email", ruleEngine.GetRule("newOrder"));
        }

        [TestMethod]
        public void CheckRuleDoesNotExist()
        {
            RulesEngine ruleEngine = new RulesEngine("ruleDoesNotExist");
            string rule = ruleEngine.GetRule("ruleDoesNotExist");
            Assert.IsNull(rule);
        }

        [TestMethod]
        public void CheckExistingRuleApplication()
        {
            RulesEngine ruleEngine = new RulesEngine("PhysicalProduct");
            bool ruleApplied = ruleEngine.ApplyRule();
            Assert.IsTrue(ruleApplied);
        }

        [TestMethod]
        public void CheckNonExistingRuleApplication()
        {
            RulesEngine ruleEngine = new RulesEngine("soemthing");
            bool ruleApplied = ruleEngine.ApplyRule();
            Assert.IsFalse(ruleApplied);
        }
    }
}
