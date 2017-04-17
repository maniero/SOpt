void PrintAnimals(IEnumerable<Animal> animals) {
  for(var animal in animals)
    Console.WriteLine(animal.Name);
}

IEnumerable<Cat> cats = new List<Cat> { new Cat("Tom") };
PrintAnimals(rats);
IEnumerable<Mouse> mouses = new List<Mouse> { new Mouse("Jerry") };
PrintAnimals(mouses);

//O código de PrintAnimals só pode funcionar porque IEnumarable é covariante:

public interface IEnumerable <out T>: IEnumerable
{
    IEnumerator<T> GetEnumerator();
}

//

public interface IComparer<in T>
{
    int Compare(T x, T y);
}

Neste caso o in indica a contravariância e permite que o seguinte código seja válido:

void CompareCats(IComparer<Cat> comparer) {
  var cat1 = new Cat("Tom");
  var cat2 = new Cat("Frajola");
  if (comparer.Compare(cat1, cat2) > 0) 
    Console.WriteLine("Tom é maior!");
}

IComparator<Animal> compareAnimals = new AnimalSizeComparator(); //sabe como comparar Animals
CompareCats(compareAnimals);

//https://pt.stackoverflow.com/q/32880/101
