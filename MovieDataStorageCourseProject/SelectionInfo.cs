namespace MovieDataStorageCourseProject
{
    public struct SelectionInfo
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public SelectionInfo(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
