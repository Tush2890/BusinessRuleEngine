using System;

namespace BusinessRuleEngine
{
    public class RulesEngine
    {
        string orderType = string.Empty;

        public RulesEngine(string orderType)
        {
            this.orderType = orderType;
        }

        public bool ApplyRule()
        {
            RulesList listOfRules = new RulesList();
            string rule = listOfRules.GetRule(this.orderType);
            if (rule == null)
            {
                Console.Write("Rule does not exist.");
                return false;
            }
            else
            {
                Console.Write(rule);
                return true;
            }
        }

        public void AddRule(string memberName, string oprator, string targetValue)
        {
            RulesList listOfRules = new RulesList();
            listOfRules.AddRule(memberName, oprator, targetValue);
        }
    }
}
