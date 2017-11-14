using System.Text;

namespace Builder.Classes
{
    public class Bread
    {
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Additives Additives { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Flour != null)
                sb.Append(Flour.Sort + "\n");
            if (Salt != null)
                sb.Append("Salt \n");
            if (Additives != null)
                sb.Append("Additionals: " + Additives.Name + " \n");
            return sb.ToString();
        }
    }
}
