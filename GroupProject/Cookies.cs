using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Cookies
    {
        private double _flour;
        private double _score = 0;
        public void ScoreCookies(double _flour)
        {
            if (_flour == 0)
            {
                Console.WriteLine(_score);
            }
            else if (_flour < 0)
            {
                Console.WriteLine("Nothing will come out of nothing");
            }
            else
            {

                _score = ((_flour / 1000) * 15) / 0.25;
                Console.WriteLine($"{Math.Round(_score)} pieces");
            }
        }
    }
}
