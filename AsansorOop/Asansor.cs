using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsansorOop
{
    public class Asansor : IKonum
    {
        public event EventHandler KataUlasti;

        public int BulunduguKat
        {
            get => default;
            set
            {
            }
        }

        public int AsansorSirasi
        {
            get => default;
            set
            {
            }
        }

        public int Kapasite
        {
            get => default;
            set
            {
            }
        }

        public Yolcu[] Yolcular
        {
            get => default;
            set
            {
            }
        }

        public AsansorDurum Durum
        {
            get => default;
            set
            {
            }
        }

        public Yon Yon
        {
            get => default;
            set
            {
            }
        }

        public IcKapi IcKapi
        {
            get => default;
            set
            {
            }
        }

        public AsansorKontrolPaneli AsansorKontrolPaneli
        {
            get => default;
            set
            {
            }
        }

        public int MevcutKat
        {
            get => default;
            set
            {
            }
        }

        public int[] HedefKatlar
        {
            get => default;
            set
            {
            }
        }

        public void KataGit()
        {
            throw new System.NotImplementedException();
        }

        public void KapiAcKapa()
        {
            throw new System.NotImplementedException();
        }
    }
}