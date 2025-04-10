using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayListTasarimi
{
    public class MyArrayList
    {
        private object[] dizi;
        private int elemanSayisi;
        private int kapasite;

        public MyArrayList()
        {
            kapasite = 4;
            dizi = new object[kapasite];
            elemanSayisi = 0;
        }

        public int Count
        {
            get { return elemanSayisi; }
        }

        public void Add(object veri)
        {
            KapasiteKontrol();
            dizi[elemanSayisi] = veri;
            elemanSayisi++;
        }

        public void Insert(int index, object veri)
        {
            if (index < 0 || index > elemanSayisi)
                throw new IndexOutOfRangeException("Geçersiz indeks!");

            KapasiteKontrol();

            for (int i = elemanSayisi; i > index; i--)
            {
                dizi[i] = dizi[i - 1];
            }

            dizi[index] = veri;
            elemanSayisi++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= elemanSayisi)
                throw new IndexOutOfRangeException("Silinecek indeks geçersiz!");

            for (int i = index; i < elemanSayisi - 1; i++)
            {
                dizi[i] = dizi[i + 1];
            }

            dizi[elemanSayisi - 1] = null;
            elemanSayisi--;
        }

        public object Get(int index)
        {
            if (index < 0 || index >= elemanSayisi)
                throw new IndexOutOfRangeException("Erişilen indeks geçersiz!");

            return dizi[index];
        }

        public override string ToString()
        {
            string sonuc = "";

            for (int i = 0; i < elemanSayisi; i++)
            {
                sonuc += dizi[i];

                if (i != elemanSayisi - 1)
                    sonuc += ", ";
            }

            return sonuc;
        }

        private void KapasiteKontrol()
        {
            if (elemanSayisi >= kapasite)
            {
                kapasite *= 2;
                object[] yeniDizi = new object[kapasite];

                for (int i = 0; i < elemanSayisi; i++)
                {
                    yeniDizi[i] = dizi[i];
                }

                dizi = yeniDizi;
            }
        }
    }
}
