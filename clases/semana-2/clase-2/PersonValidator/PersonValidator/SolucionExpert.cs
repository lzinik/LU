using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PersonRepository.Entities;
using PersonRepository.Interfaces;

namespace PersonValidator
{
    public class SolucionExpert : SolucionAdvanced, IValidatorExpert
    {
        public bool Run(Person person, Expression<Func<Person, bool>> validation)
        {
            var run = validation.Compile();
            return run(person);
        }
    }
}