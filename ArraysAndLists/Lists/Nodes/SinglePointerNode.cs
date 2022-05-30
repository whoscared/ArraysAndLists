namespace ArraysAndLists.Lists.Nodes
{
    class SinglePointerNode
    {
        public int Data;
        public SinglePointerNode Next;
        public SinglePointerNode(int data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
