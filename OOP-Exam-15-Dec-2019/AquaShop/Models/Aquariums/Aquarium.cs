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
        private readonly List<IDecoration> decorations;
        private readonly List<IFish> fish;

        protected Aquarium()
        {
            this.decorations = new List<IDecoration>();
            this.fish = new List<IFish>();
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

        public ICollection<IDecoration> Decorations
                => this.decorations.AsReadOnly();

        public ICollection<IFish> Fish 
                => this.fish.AsReadOnly();


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
