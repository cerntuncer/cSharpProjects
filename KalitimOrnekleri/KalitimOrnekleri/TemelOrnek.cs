using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace KalitimOrnekleri
    {
        // Base (üst) sınıf
        class Hayvan
        {
            public string Ad;

            public void SesCikar()
            {
                Console.WriteLine("Hayvan ses çıkarıyor.");
            }
        }

        // Derived (türemiş) sınıf
        class Kedi : Hayvan
        {
            public void Miyavla()
            {
                Console.WriteLine("Kedi miyavlıyor.");
            }
        }

      
    
}
