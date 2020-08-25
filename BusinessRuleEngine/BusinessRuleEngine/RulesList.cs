using System.Collections.Generic;

namespace BusinessRuleEngine
{
    public class RulesList : IRule
    {
        List<string> listOfRules = new List<string>() {
            "PhysicalProduct-payment-generate a packing slip; generate a commission payment to agent",
            "Book-payment-create a duplicate slip for royalty department;generate a commission payment to agent",
            "NewMembership-payment-activate; email owner and inform about activate",
            "UpgradeMembership-payment-upgrade; email owner and inform about upgrade",
            "Video-payment-add a free 'First Aid' video to packing slip"
        };

        public void AddRule(string memberName, string oprator, string targetValue)
        {
             this.listOfRules.Add(memberName + "-" + oprator + "-" + targetValue);
        }

        public string GetRule(string memberName)
        {
            return this.listOfRules.Find(rule => rule.Contains(memberName));
        }
    }

}
