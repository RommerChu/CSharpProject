using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101
{
    internal class Test2
    {

        class ParentClass
        {
            int mark;
            public ParentClass(int mark)
            {
                this.mark = mark;
            }
            public void ParentClassMeth()
            {
                int perc = this.mark / 100;
                Console.WriteLine("The Percentage Obtained is : {0}", perc);
            }

        }

        class ChildInheritedClass : ParentClass
        {
            static void Main(string[] args)
            {

                //ParentClass p = new ParentClass(600);
                //p.ParentClassMeth();


                ChildInheritedClass obj = new ChildInheritedClass(600);
                obj.ParentClassMeth();
            }
        }



    }
}
