namespace AquaShop.Models.Aquariums
{
    using AquaShop.Models.Aquariums.Contracts;
    using AquaShop.Models.Decorations.Contracts;
    using AquaShop.Models.Fish.Contracts;
    using AquaShop.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Aquarium : IAquarium
    {
        private string name;

        protected Aquarium()
        {
            this.Decorations = new List<IDecoration>();
            this.Fish = new List<IFish>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }
                this.name = value;
            }
        }

        public int Capacity { get; }

        public int Comfort
            => this.Decorations.Sum(c => c.Comfort);

        public ICollection<IDecoration> Decorations { get; }

        public ICollection<IFish> Fish { get; }


        public void AddDecoration(IDecoration decoration)
        {

        }

        public void AddFish(IFish fish)
        {

        }

        public void Feed()
        {

        }

        public string GetInfo()
        {

        }

        public bool RemoveFish(IFish fish)
        {

        }

    }
}
