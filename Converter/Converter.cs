using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Converter

    {
        private double _usd;
        private double _eur;
        private double _pln;

        public Converter(double usd, double eur, double pln)
        {
            _usd = usd;
            _eur = eur;
            _pln = pln;
        }

        public double UAHtoUSD(double uah)
        {
            return uah / _usd;
        }

        public double UAHtoEUR(double uah)
        {
            return uah / _eur;
        }

        public double UAHtoPLN(double uah)
        {
            return uah / _pln;
        }

        public double USDtoUAH(double usd)
        {
            return usd * _usd;
        }

        public double EURtoUAH(double eur)
        {
            return eur * _eur;
        }

        public double PLNtoUAH(double pln)
        {
            return pln * _pln;
        }
    }
}
