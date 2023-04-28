# Interfaces

Em C#, interfaces are an important tool of Object-Oriented Programming (OOP). Interfaces define a set of members that a class must implement to meet the requirements of the interface.

An interface is defined using the "interface" keyword, followed by the name of the interface and a list of members that the interface requires. Interface members can be properties, methods, events, or other types of members.

For example, suppose you have an interface called "IAnimal" that defines the required members to represent an animal:

    interface IAnimal 
    {
        void Move();
        void Eat();
    }

Any class that implements the "IAnimal" interface must provide an implementation for the "Move()" and "Eat()" methods. The class's implementation must meet the requirements of the interface.

For example, the "Dog" class can implement the "IAnimal" interface as follows:

    class Dog : IAnimal 
    {
        public void Move() 
        {
            Console.WriteLine("The dog is moving.");
        }

        public void Eat() 
        {
            Console.WriteLine("The dog is eating.");
        }
    }

Note that the "Dog" class implements the "Move()" and "Eat()" methods of the "IAnimal" interface. When you use the "Dog" class, you can call the interface methods directly:

    Dog myDog = new Dog();
    myDog.Move(); // Output: The dog is moving.
    myDog.Eat(); // Output: The dog is eating.

Interfaces can also be used as parameter types in methods or properties in classes. For example:

    class AnimalHouse 
    {
        private List<IAnimal> animals;

        public AnimalHouse() 
        {
            animals = new List<IAnimal>();
        }

        public void AddAnimal(IAnimal animal) 
        {
            animals.Add(animal);
        }

        public void FeedAnimals() 
        {
            foreach (IAnimal animal in animals) 
            {
                animal.Eat();
            }
        }
    }

In this example, the "AnimalHouse" class uses the "IAnimal" interface as a parameter type in the "AddAnimal()" method and in the "animals" property. The class also uses the "IAnimal" interface as a variable type in the "foreach" loop of the "FeedAnimals()" method. This allows you to add any class that implements the "IAnimal" interface to the list of animals in the "AnimalHouse" class instance and call the "Eat()" method on each animal in the list.

# Injeção de Dependência

A Injeção de Dependência (ID) é uma técnica da programação orientada a objetos que permite a passagem de objetos (dependências) para uma classe a partir de uma fonte externa, como um contêiner de Inversão de Controle (IoC), por exemplo. A ID é implementada através da passagem das dependências para uma classe por meio de construtores, propriedades ou métodos.

A principal vantagem da ID é que ela permite que as classes sejam mais modulares, flexíveis e fáceis de testar. Em vez de criar e gerenciar as suas próprias dependências, as classes recebem as suas dependências já resolvidas de uma fonte externa. Isso permite que as classes sejam criadas com suas dependências já resolvidas, o que as torna mais independentes e fáceis de testar.

    public class Cliente 
    {
        private Servico servico;

        public Cliente(Servico servico) 
        {
            this.servico = servico;
        }

        public void FazerPedido() 
        {
            servico.ProcessarPedido();
        }
    }

Neste exemplo, a classe "Cliente" recebe uma instância da classe "Servico" por meio de seu construtor. Quando a classe "Cliente" é criada, a instância de "Servico" é resolvida e passada para a classe "Cliente". Isso permite que a classe "Cliente" seja criada com suas dependências já resolvidas.


# Bibliotecas de ID

A ID é frequentemente implementada usando um contêiner IoC, que gerencia a criação e a resolução de dependências. Algumas das bibliotecas de ID mais populares para o C# incluem:

* Ninject
* Autofac
* Unity

# Conclusão

A Injeção de Dependência é uma técnica importante da programação orientada a objetos que permite que as classes sejam mais flexíveis, modularizadas e fáceis de testar. Ele é frequentemente implementado usando um contêiner IoC, que gerencia a criação e a resolução de dependências. Com a ID, as classes podem ser criadas com suas dependências já resolvidas, o que as torna mais independentes e fáceis de testar.
