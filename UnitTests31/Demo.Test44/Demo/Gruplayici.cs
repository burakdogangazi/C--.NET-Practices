using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Gruplayici
    {
        private int _grupSayisi;

        public Gruplayici(int grupSayisi)
        {
            _grupSayisi = grupSayisi;
        }

        public List<List<Olcum>> Grupla(List<Olcum> olcumler)
        {
            var gruplar = new List<List<Olcum>>();

            for (int i = 0; i < olcumler.Count;i+= _grupSayisi)
            {
                
                var grup = olcumler.Skip(i).Take(_grupSayisi).ToList();
                gruplar.Add(grup);
            }

            
            return gruplar; //testi geçmemizi sağlayacak en basit kodu yazdık yeşil
        }
    }
}