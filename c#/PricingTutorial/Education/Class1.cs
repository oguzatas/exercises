namespace Education
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEducationManager educationManager = new EducationManager(new EfEducationDal());
            Console.ReadLine();
        }

    }

    public class Education
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    class EducationManager : IEducationManager
    {
        IEducationDal _educationDal;
        ISaleService _saleService; 
        public EducationManager(IEducationDal educationDal, ISaleService  saleService)
        {
            _educationDal = educationDal;
            _saleService = saleService;
        }
        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public List<Education> GetList()
        {
            var educations = _educationDal.GetList();

            _saleService.UpdatePrice(educations);
            
            return educations;
            
        }

        
    }

    class EfEducationDal : IEducationDal
    {
        public List<Education> GetList()
        {
            return new List<Education>(); 
        }
    }

    public interface IEducationDal
    {
        public List<Education> GetList();
    }

    public interface IEducationManager
    {
        public List<Education> GetList();
    }

    public interface ISaleService
    {
        void UpdatePrice(List<Education> education);
    }

    class StandartPriceSaleManager : ISaleService
    {
        public void UpdatePrice(List<Education> educations)
        {
            foreach (var education in educations)
            {
                education.Price = GetDefaultLowerPrice();
            }
        }
        private decimal GetDefaultLowerPrice()
        {
            // code to connect db and get the lower price
            return 25;
        }
    }

    class PercentPriceSaleManager : ISaleService
    {
        public void UpdatePrice(List<Education> educations)
        {
            foreach (var education in educations)
            {
                education.Price = ApplySale();
            }
        }

        private decimal ApplySale()
        {
            return Convert.ToDecimal(0.9);
        }
    }
}