namespace IteratorPattern
{
    public class Iterator : IIterator
    {
        private Collection _collection;
        private int _currentPosition = 0;

        public int Step { get; set; } = 1;

        public bool IsDone
        {
            get { return _currentPosition >= _collection.Count; }
        }

        public CollectionItem CurrentItem
        {
            get { return _collection[_currentPosition]; }
        }

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public CollectionItem First()
        {
            _currentPosition = 0;

            return _collection[_currentPosition];
        }

        public CollectionItem Next()
        {
            _currentPosition += Step;

            if (!IsDone) return _collection[_currentPosition];
            else return null;
        }
    }
}
