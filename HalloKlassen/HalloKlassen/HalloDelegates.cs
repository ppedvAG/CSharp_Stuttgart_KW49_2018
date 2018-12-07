using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    delegate void EinfacherDelegate();
    delegate void MitParameterDelegate(string mregregergergergg);
    delegate long CalcDelegate(int a, int b);

    class HalloDelegates
    {
        public HalloDelegates()
        {
            EinfacherDelegate meinDings = EinfacheMethode;
            Action meinDingsAlsAction = EinfacheMethode;
            Action meinDingsAlsActionAno = delegate () { Console.WriteLine("Hallo"); };
            Action meinDingsAlsActionAno2 = () => { Console.WriteLine("Hallo"); };
            Action meinDingsAlsActionAno3 = () => Console.WriteLine("Hallo");

            MitParameterDelegate paraDele = ZeigeText;
            Action<string> paraDeleAlsAxction = ZeigeText;
            Action<string> paraDeleAlsAxctionAno = (string txt) => { Console.WriteLine(txt); };
            Action<string> paraDeleAlsAxctionAno2 = x => Console.WriteLine(x);

            CalcDelegate calc = Minus;
            Func<int, int, long> calcAsFunc = Sum;
            CalcDelegate calcAno = (a, b) => { return a + b; };
            Func<int, int, long> calcAno2 = (a, b) => a + b;

            var texte = new List<string>();
            texte.Where(Filter);
            texte.Where(lala => lala.StartsWith("B")).OrderBy(x => x.Length);

        }

        bool Filter(string lala)
        {
            if (lala.StartsWith("B"))
                return true;
            else
                return false;
        }

        private long Minus(int a, int b)
        {
            return a - b;
        }

        private long Sum(int a, int b)
        {
            return a + b;
        }

        public void EinfacheMethode()
        {
            Console.WriteLine("Hallo");
        }

        /// <summary>
        /// Zeigt Text an
        /// </summary>
        /// 
        /// <param name="txt">Der Text der angrhelkwenfkjnew jnwevkj  wekjn</param>
        /// <remarks>Wird textanzeg</remarks>
        public void ZeigeText(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
