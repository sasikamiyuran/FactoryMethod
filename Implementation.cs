namespace Implementation
{
    public abstract class DiscountService
    {
        public abstract int DiscountPercentation { get; }
        public override string ToString()
        {
            return GetType().Name;
        }
    }

    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;
        public CountryDiscountService(string countryIdentifier)
        {
            this._countryIdentifier = countryIdentifier;

        }

        public override int DiscountPercentation
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "LK":
                        return 25;
                    default:
                        return 10;
                }
            }
        }
    }

    public class CodeDiscountService : DiscountService
    {
        private readonly string _codeIdentifire;
        public CodeDiscountService(string codeIdentifier)
        {
            this._codeIdentifire = codeIdentifier;
        }

        public override int DiscountPercentation
        {
            get => 15;
        }
    }

    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;

        public CountryDiscountFactory(string countryIdentifier)
        {
            this._countryIdentifier = countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly string _codeIdentifire;

        public CodeDiscountFactory(string codeIdentifier)
        {
            this._codeIdentifire = codeIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_codeIdentifire);
        }
    }
}