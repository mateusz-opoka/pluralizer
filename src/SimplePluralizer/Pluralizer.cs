namespace SimplePluralizer
{
    public class Pluralizer
    {
        private readonly string[] _forms;

        public Pluralizer(string singularNominativ, string pluralNominativ)
            : this(singularNominativ, pluralNominativ, pluralNominativ)
        { }

        public Pluralizer(string singularNominativ, string pluralNominativ, string pluralGenitive)
        {
            _forms = new[] { singularNominativ, pluralNominativ, pluralGenitive };
        }

        public string Format(int n)
        {
            if (n == 1) return _forms[0];
            if (n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20)) return _forms[1];
            return _forms[2];
        }
    }
}
