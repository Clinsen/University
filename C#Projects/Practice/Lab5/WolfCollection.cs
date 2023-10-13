using System.Collections;

public class WolfCollection
{
    private ArrayList _wolfList;
    private List<Wolf> _wolfGenericList;

    public WolfCollection()
    {
        _wolfList = new ArrayList();
        _wolfGenericList = new List<Wolf>();
    }

    // Додавання об'єкту Wolf до колекції з використанням класу ArrayList
    public void AddWolf(Wolf wolf)
    {
        _wolfList.Add(wolf);
    }

    // Додавання об'єкту Wolf до колекції з використанням класу List<>
    public void AddWolfGeneric(Wolf wolf)
    {
        _wolfGenericList.Add(wolf);
    }

    // Повернення об'єкту Wolf за індексом з використанням класу ArrayList
    public Wolf GetWolf(int index)
    {
        return _wolfList[index] as Wolf;
    }

    // Повернення об'єкту Wolf за індексом з використанням класу List<>
    public Wolf GetWolfGeneric(int index)
    {
        return _wolfGenericList[index];
    }

    // Повернення кількості елементів у колекції з використанням класу ArrayList
    public int Count()
    {
        return _wolfList.Count;
    }

    // Повернення кількості елементів у колекції з використанням класу List<>
    public int CountGeneric()
    {
        return _wolfGenericList.Count;
    }
}