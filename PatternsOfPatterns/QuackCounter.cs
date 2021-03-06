// Decorator pattern

namespace DuckSimulator
{
    public class QuackCounter : Quackable
    {        
        Quackable duck;
        static int numberOfQuacks;
        
        public QuackCounter(Quackable duck)
        {
            this.duck = duck;
        }
        
        public void Quack()
        {
            duck.Quack();
            numberOfQuacks++;
        }
        
        public static int GetQuacks()
        {
            return numberOfQuacks;
        }
        
        public void RegisterObserver(Observer observer)
        {            
        }
        
        public void NotifyObservers()
        {            
        }
    }   
}