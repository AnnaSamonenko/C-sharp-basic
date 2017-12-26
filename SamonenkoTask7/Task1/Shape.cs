namespace Task1
{
    public abstract class Shape
    {
        private string name;

        protected Shape(string name)
        {
            this.name = name;
        }

        public abstract double GetArea();
        

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return GetName() + " with area: " + GetArea();
        }
    }
}