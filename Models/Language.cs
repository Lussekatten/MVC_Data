using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EF_test_01.Models
{
    public class Language
    {
        //Test
        public Language()
        {
            SpokenBy = new List<Person>();
        }

        [Key]
        public int LangId { get; set; }
        public string Name { get; set; }
        public List<Person> SpokenBy { get; set; }
    }
}
