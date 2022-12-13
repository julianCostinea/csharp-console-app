using System.Collections;

namespace ConsoleAppClassPractice;

public class Generics
{
    public class GenericsList<T>
    {
        private IList<T> _genericList;

        public void Add(T item)
        {
            _genericList.Add(item);
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        private IDictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }
    }

    public class Product
    {
        private readonly int _salesTax;

        public Product(int salesTax)
        {
            _salesTax = salesTax;
        }

        public int GetSalePrice(int price)
        {
            return price + _salesTax;
        }
    }

    //GENERICS CONSTRAINTS

    //interface
    public static T Max<T>(T arg1, T arg2) where T : IComparable
    {
        return arg1.CompareTo(arg2) > 0 ? arg1 : arg2;
    }

    //class
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public int CalculateDiscount(TProduct product)
        {
            return product.GetSalePrice(22) - 5;
        }
    }

    //struct
    //restricts type argument to be non-nullable value type only.
    public class DataStore<T> where T : struct
    {
        private T _item;

        public DataStore()
        {
        }

        public DataStore(T item)
        {
            _item = item;
        }
    }

    //valid
    DataStore<int> store = new DataStore<int>(2);
    DataStore<char> store2 = new DataStore<char>();
    //not valid
    //DataStore<string> store = new DataStore<string>();
    //DataStore<ArrayList> store = new DataStore<ArrayList>();
    
    //class
    public class DataStore2<T> where T : class
    {
        public T Data { get; set; }
    }
    DataStore2<string> store3 = new DataStore2<string>(); // valid
    //DataStore<MyClass> store = new DataStore<MyClass>(); // valid
    //DataStore2<IMyInterface> store5 = new DataStore2<IMyInterface>(); // valid
    DataStore2<IEnumerable> store6 = new DataStore2<IEnumerable>(); // valid
    DataStore2<ArrayList> store7 = new DataStore2<ArrayList>(); // valid
    
    //DataStore<int> store = new DataStore<int>(); // not valid
    
    //new()
    public class NewConstraint<T> where T : class, new()
    {
        public T Data { get; set; }

        public void CreateNew()
        {
            var obj = new T();
        }
    }
}