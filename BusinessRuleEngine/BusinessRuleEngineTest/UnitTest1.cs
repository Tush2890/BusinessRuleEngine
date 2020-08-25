using BusinessRuleEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckRuleAddition()
        {
            IRule rule = new RulesList();
            rule.AddRule("newOrder", "payment", "make payment;send email");
            Assert.AreEqual("newOrder-payment-make payment;send email", rule.GetRule(0));
        }

        [TestMethod]
        public void CheckRuleDoesNotExist()
        {
            IRule rule = new RulesList();
            string ruleExists = rule.GetRule("negativeScenario");
            Assert.IsNull(ruleExists);
        }

        [TestMethod]
        public void CheckRuleExist()
        {
            IRule rule = new RulesList();
            string ruleExists = rule.GetRule("newOrder");
            Assert.IsNotNull(rule);
        }

        [TestMethod]
        public void CheckExistingRuleApplication()
        {
            RulesEngine ruleEngine = new RulesEngine("newOrder");
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
