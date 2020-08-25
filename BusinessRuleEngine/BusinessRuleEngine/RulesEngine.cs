using System;

namespace BusinessRuleEngine
{
    public class RulesEngine
    {
        string orderType = string.Empty;
        RulesList listOfRules = new RulesList();

        public RulesEngine(string orderType)
        {
            this.orderType = orderType;
        }

        public bool ApplyRule()
        {
            string rule = this.GetRule(this.orderType);
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

        public void AddRule(string oprator, string targetValue)
        {
            listOfRules.AddRule(this.orderType, oprator, targetValue);
        }

        public string GetRule(string orderType)
        {
            string rule = listOfRules.GetRule(orderType);
            return rule;
        }
    }
}
