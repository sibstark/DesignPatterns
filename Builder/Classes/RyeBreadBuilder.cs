namespace Builder.Classes
{
    public class RyeBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
        }

        public override void SetFlour()
        {
            Bread.Flour = new Flour { Sort = "Ржаная мука 1 сорт" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }
    }
}
