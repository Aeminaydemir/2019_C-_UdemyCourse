using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class CourseManager
    {
      public void Add()
        {
            Course course = new Course();
            //course burada kullanabiliyorum çünkü; internal aynı assembly 
            //(bağlı bulunduğu proje) 
            // içinde bulunan şeyleri kullanmana izin veriyor.
        }
    }
    
}
