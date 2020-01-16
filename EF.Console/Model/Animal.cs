using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.Model
{
    public delegate void RunAction();
    public class GenericTest
    {
        public event RunAction RunAction;
        public void Run()
        {
            List<Dog> dogs = new List<Dog>();
            List<Pig> pigs = new List<Pig>();

            Animal animal = new Animal();
            Dog dog = new Dog(this);
            animal = dog;


            IAnimalHouse<Animal> animalHouse = new AnimalHouse<Animal>();
            IAnimalHouse<Dog> dogHouse = new AnimalHouse<Dog>();

            animalHouse.AddAnimal(new Animal() { SkinColor = "yellow" });

            //animalHouse = dogHouse;  //协变
            //dogHouse = animalHouse;  //逆变
            this.RunAction();
            System.Console.ReadLine();
        }
    }

    /// <summary>
    /// 动物房子接口（所有动物的房子必须继承该接口，例如红砖动物房子，别墅动物房）
    /// 协变：
    /// 1、协变只能用在接口或者委托类型中；
    /// 2、协变是在T泛型前使用out关键字;
    /// 3、逆变是在T泛型前使用in关键字;
    /// 4、协变的作用就是可以将子类泛型隐式转换为父类泛型，而逆变就是将父类泛型隐式转换为子类泛型；
    /// 5、协变时泛型无法作为参数、逆变时泛型无法作为返回值
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAnimalHouse<T> where T : Animal, new()
    {
        void AddAnimal(T a);
        bool RemoveAnimal(T a);
    }
    /// <summary>
    /// 
    /// 
    /// 1、泛型其实就是一个不确定的类型，可以用在类和方法上，泛型在声明期间没有明确的定义类型，编译完成之后会生成一个占位符，只有在调用者调用时，传入指定的类型，才会用确切的类型将占位符替换掉。
    /// 2、泛型约束就是对泛型(传入的类型)进行约束，约束就是指定该类型必须满足某些特定的特征：where 泛型 : 泛型约束1、泛型约束2....，如果有new()约束的话则必须放在最后
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AnimalHouse<T> : IAnimalHouse<T> where T : Animal, new()
    {
        private List<T> animal = new List<T>();

        public void AddAnimal(T a)
        {
            animal.Add(a);
        }

        public bool RemoveAnimal(T a)
        {
            return animal.Remove(a);
        }
    }
    //动物类
    public class Animal
    {
        //随便定义出一个属性和方法
        public String SkinColor { get; set; }//皮肤颜色
                                             //会跑的方法
        public virtual void CanRun()
        {
            System.Console.WriteLine("Animal Run Can");
        }
    }

    //动物子类 Dog
    public class Dog : Animal
    {
        public Dog() { }
        public Dog(GenericTest genericTest)
        {
            genericTest.RunAction += CanRun;
        }
        public string Name { get; set; }
        //重写父类方法
        public override void CanRun()
        {
            System.Console.WriteLine("Dog Can Run");
        }
    }

    //动物子类 Pig
    public class Pig : Animal
    {
        public Pig() { }
        public Pig(GenericTest genericTest)
        {
            genericTest.RunAction += CanRun;
        }
        //重写父类方法
        public override void CanRun()
        {
            System.Console.WriteLine("Pig Can Run");
        }
    }

}
