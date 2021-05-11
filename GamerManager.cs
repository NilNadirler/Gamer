using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{


    class GamerManager : IGamerService
    {
        IUseerValidation _useerValidation;

        public GamerManager(IUseerValidation useerValidation)
        {
            _useerValidation = useerValidation;
        }


        public void Add(Gamer gamer)
        {
            if (_useerValidation.Validate(gamer)==true)
            {
                Console.WriteLine("Kayit Oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama Basarisiz");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit Guncellendi");
        }
    }
}
