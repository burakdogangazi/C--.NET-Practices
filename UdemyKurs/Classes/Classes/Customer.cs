using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //public string FirstName;// bu da hata vermez set get zorunlu deil ama böyle yaparsan field tanımlarsın
        // class a özgü olduğı için property tanımı kullanılmalı
        public int Id { get; set; }// property tanımı

        public string _firstName;// field tanımlanır
        public string FirstName//property yazılır
        {
            get
            {
                return "Mr. "+_firstName;
            }
            // Müşteriyi direk adını kaydediyor ama çağırınca Mr ekliyor.
            set
            {
                _firstName = value;
            }

        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
