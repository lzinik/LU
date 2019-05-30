using PersonRepository.Interfaces;
using PersonRepository;

namespace PersonValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var solucion = new SolucionBasic();
            var validatorTest = new ValidatorTest();
            validatorTest.Validate(SolucionBasic);
        }
    }
}
