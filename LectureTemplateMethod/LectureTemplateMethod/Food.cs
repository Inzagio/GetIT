using System.Runtime.InteropServices;

namespace LectureTemplateMethod
{
   public abstract class Food
   {
       protected Treatment[] _treatments;
        public virtual void Make()
        {
            GetIngredients();
            PrepareIngredients();
            MixIngredients();
            foreach (var treatment in _treatments)
            {
                treatment.Do(this);
            }

            PreCool();
            MakeParts();
            PostCool();
            Wrapper();
        }

       protected abstract void Wrapper();

       protected abstract void PostCool();

       protected abstract void MakeParts();

       protected abstract void PreCool();

       protected abstract void MixIngredients();

       protected abstract void PrepareIngredients();

       protected abstract void GetIngredients();
   }
}
