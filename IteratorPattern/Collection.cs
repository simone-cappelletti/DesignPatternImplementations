namespace IteratorPattern
{
    public class Collection : ICollection
    {
        List<CollectionItem> _items = new List<CollectionItem>();

        public int Count
        {
            get { return _items.Count; }
        }

        public CollectionItem this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}
