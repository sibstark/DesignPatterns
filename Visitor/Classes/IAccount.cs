namespace Visitor.Classes
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
