namespace BottleFillingSimulation
{
    class Bottle
    {
        public int Capacity { get; set; }
        public int Content;

        public Bottle(int capacity)
        {
            Capacity = capacity;
        }

        public void FillFromTap()
        {
            Content = Capacity;
        }

        public int Empty()
        {
            var oldContent = Content;
            Content = 0;
            return oldContent;
        }

        public bool Fill(int amount)
        {
            if (Content + amount <= Capacity) return false;
            {
                Content += amount;
            }
            return true;
        }

        public bool FillToTop(Bottle otherBottle)
        {
            var amountNeeded = Capacity - Content;
            if (otherBottle.Content < amountNeeded) return false;
            Content = Capacity;
            otherBottle.Remove(amountNeeded);
            return true;
        }
        private void Remove(int amountNeeded)
        {
            Content -= amountNeeded;
        }

        public bool IsEmpty()
        {
            return Content == 0;
        }
    }
}
