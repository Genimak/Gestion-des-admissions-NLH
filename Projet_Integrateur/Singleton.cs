using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Integrateur
{
    class Singleton
    {
        private static Singleton instance = null;

        public  DB_HopitalEntities hopitalBDD ;

        private Singleton()
        {
            hopitalBDD = new DB_HopitalEntities();


        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;

            }


        }
    }
}
