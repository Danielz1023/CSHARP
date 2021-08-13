namespace CSHARP.DesignPatterns.Creational
{
    class Client
    {
        private FurnitureFactory factory;
        public Client(FurnitureFactory f){this.factory = f;}
        public Chair sitOnChair(){
            return factory.createChair();
        }
        public Sofa sitOnSofa(){
            return factory.createSofa();
        }
    }
    public interface Chair{string sitOn();}
    public interface Sofa{string sitOn();}
    public interface FurnitureFactory
    {
        Chair createChair();
        Sofa createSofa();
    }
    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new VictorianChair();
        }

        public Sofa createSofa()
        {
            return new VictorianSofa();
        }
    }
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new ModernChair();
        }

        public Sofa createSofa()
        {
            return new ModernSofa();
        }
    }
    class VictorianChair : Chair
    {
        public string sitOn()
        {
            return"Sitting on a Victorian chair";
        }
    }
    class VictorianSofa : Sofa
    {
        public string sitOn()
        {
            return "Sitting on a Victorian sofa";
        }
    }
    class ModernChair : Chair
    {
        public string sitOn()
        {
            return "Sitting on a modern chair";
        }
    }
    class ModernSofa : Sofa
    {
        public string sitOn()
        {
            return "Sitting on a modern sofa";
        }
    }
}