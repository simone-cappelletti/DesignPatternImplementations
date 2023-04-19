namespace IteratorPattern
{
    public interface IIterator
    {
        CollectionItem First();
        CollectionItem Next();
        bool IsDone { get; }
        CollectionItem CurrentItem { get; }
    }
}