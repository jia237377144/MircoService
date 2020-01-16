using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.EnumeratorDemo
{
    public class EnumeratorTest
    {
        public static void Run()
        {
            //    object[] values = { "a", "b", "c", "d", "e" };
            //    IterationSample collection = new IterationSample(values, 3);
            //    foreach (object x in collection)
            //    {
            //        System.Console.Write(x);
            //        foreach (object j in collection)
            //        {
            //            System.Console.Write(" " + j + ",");
            //        }
            //        System.System.Console.WriteLine();
            //    }
            //}
            //IEnumerable<Int32> iterable = CreateEnumerable();
            //IEnumerator<Int32> iterator = iterable.GetEnumerator();
            //System.Console.WriteLine("开始迭代");
            //while (true)
            //{
            //    System.Console.WriteLine("调用MoveNext方法……");
            //    Boolean result = iterator.MoveNext();
            //    System.Console.WriteLine("MoveNext方法返回的{0}", result);
            //    if (!result)
            //    {
            //        break;
            //    }
            //    System.Console.WriteLine("获取当前值……");
            //    System.Console.WriteLine("获取到的当前值为{0}", iterator.Current);
            //}

            var test = Test();
            
            var iterator = test.GetEnumerator();
            bool result = true;
            while(result)
            {
                result = iterator.MoveNext();
                System.Console.WriteLine(iterator.Current);
            }


            System.Console.ReadKey();


        }

        static IEnumerable<int> Test()
        {
            var testArray = new int[] { 1, 2, 3, 4, 5 };
            foreach (var data in testArray)
            {
                System.Console.WriteLine(data);
                yield return data;
            }
        }
        static readonly String Padding = new String(' ', 30);
        static IEnumerable<Int32> CreateEnumerable()
        {
            System.Console.WriteLine("{0} CreateEnumerable()方法开始", Padding);
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("开始 yield {0}", i);
                yield return i;
                System.Console.WriteLine("{0}yield 结束", Padding);
            }
            System.Console.WriteLine("{0} Yielding最后一个值", Padding);
            yield return -1;
            System.Console.WriteLine("{0} CreateEnumerable()方法结束", Padding);
        }

        class IterationSample : IEnumerable
        {
            Object[] values;
            Int32 startingPoint;
            public IterationSample(Object[] values, Int32 startingPoint)
            {
                this.values = values;
                this.startingPoint = startingPoint;
            }
            public IEnumerator GetEnumerator()
            {
                //return new IterationSampleEnumerator(this);
                for (int index = 0; index < this.values.Length; index++)
                {
                    yield return values[(index + this.startingPoint) % this.values.Length];
                }
            }
            class IterationSampleEnumerator : IEnumerator
            {
                IterationSample parent;//迭代的对象  #1
                Int32 position;//当前游标的位置 #2
                internal IterationSampleEnumerator(IterationSample parent)
                {
                    this.parent = parent;
                    position = -1;// 数组元素下标从0开始，初始时默认当前游标设置为 -1，即在第一个元素之前， #3
                }

                public bool MoveNext()
                {
                    if (position != parent.values.Length) //判断当前位置是否为最后一个，如果不是游标自增 #4
                    {
                        position++;
                    }
                    return position < parent.values.Length;
                }

                public object Current
                {
                    get
                    {
                        if (position == -1 || position == parent.values.Length)//第一个之前和最后一个自后的访问非法 #5
                        {
                            throw new InvalidOperationException();
                        }
                        Int32 index = position + parent.startingPoint;//考虑自定义开始位置的情况  #6
                        index = index % parent.values.Length;
                        return parent.values[index];
                    }
                }

                public void Reset()
                {
                    position = -1;//将游标重置为-1  #7
                }
            }
        }
    }
}
