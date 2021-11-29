using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EncapsulationOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Daire isimli bir class'a aşağıdaki şekilde nesne oluşturma kuralları uygulayınız.
            //Pi sayısı olarak bir özelik tutunuz. Bu özelliğin değerini 3 atayınız.
            //Pi sayı değerini dışardan gönderiniz.
            //Bu dairenin çevresini ve alanını hesaplayınız.


            Daire d1 = new Daire();
            d1.radius = 50;
            d1.Alan();
            d1.Cevre();

            Daire d2 = new Daire(3.14, 50);
            d2.Alan();
            d2.Cevre();

        }
    }
}
