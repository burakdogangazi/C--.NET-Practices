namespace Inheritance
{
    public abstract class Animal
    {
        public int weight;
        public int lenght;
        public string name;
        public int energy;
        public string GetProperties()
        {

            return string.Format("Name : {0} Lenght : {1} Weight : {2} ", name, lenght, weight);

        }

        public abstract void Move();

        public virtual void Sleep()// isteyen türetsin isteyemeyen türetmesin
        {
            energy += 5;
        }

        //abstract animalden türüyen dğeri sınıflarda bu metodlar olmak zorunda

    }
}
