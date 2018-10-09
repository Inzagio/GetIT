using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LectureTemplateMethod
{
    class ChocolateCake : Cake
    {
        public ChocolateCake()
        {
            _treatments = new Treatment[]
            {
                new BakeInOvenTreatment()
            };
        }
        protected override void GetIngredients()
        {
            
        }

        protected override void PreCool()
        {
            Wait();
        }

        protected override void MakeParts()
        {
            Slice(0);
            Slice(45);
            Slice(90);
        }

    }
}
