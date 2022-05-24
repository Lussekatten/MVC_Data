using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_test_01.Models
{
    public class PersonLanguage
    {
        public int PersonId { get; set; }
        public int LanguageId { get; set; }
        public Person Person { get; set; }
        public Language Language { get; set; }
    }
}
