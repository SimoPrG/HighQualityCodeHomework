namespace ChefInCSharp
{
    public abstract class Vegetable
    {
        private bool isPeeled;
        private bool isCut;
        private bool isRotten;

        protected Vegetable(string name)
        {
            this.Name = name;
            this.IsPeeled = false;
            this.IsCut = false;
            this.IsRotten = false;
        }

        public string Name { get; private set; }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                if (!this.isPeeled)
                {
                    this.isPeeled = value;
                }
            }
        }

        public bool IsCut
        {
            get
            {
                return this.isCut;
            }

            set
            {
                if (!this.isCut)
                {
                    this.isCut = value;
                }
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }

            set
            {
                if (!this.isRotten)
                {
                    this.isRotten = value;
                }
            }
        }
    }
}
