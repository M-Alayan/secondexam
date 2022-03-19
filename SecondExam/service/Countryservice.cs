using SecondExam.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondExam.service
{
    public class Countryservice:ICountryservice
    {
        SEContext context;
        public Countryservice(SEContext _context)
        {
            context = _context;
        }

        public List<Country> licountry()
        {
            List<Country> licountry = context.country.ToList();
            return licountry;
        }
    }
}
