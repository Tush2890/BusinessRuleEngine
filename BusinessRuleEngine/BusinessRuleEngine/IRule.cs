namespace BusinessRuleEngine
{
    public interface IRule
    {
        void AddRule(string memberName, string oprator, string targetValue);
        string GetRule(string memberName);
    }
}
