using PersonRepository.Interfaces;
using PersonRepository;

namespace PersonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var validatorTest = new ValidatorTest();
            var solucionBasic = new SolucionBasic();
            validatorTest.Validate(solucionBasic);
        }
    }
}
