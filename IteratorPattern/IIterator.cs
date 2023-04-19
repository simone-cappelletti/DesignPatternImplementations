namespace IteratorPattern
{
    public interface IIterator
    {
        CollectionItem First();
        CollectionItem Next();
        CollectionItem CurrentItem { get; }
        bool IsDone { get; }
        int Step { get; set; }
    }
}