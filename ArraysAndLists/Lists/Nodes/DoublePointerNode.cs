namespace ArraysAndLists.Lists.Nodes
{
    class DoublePointerNode
    {
        public int Data;
        public DoublePointerNode Next;
        public DoublePointerNode Previous;

        public DoublePointerNode(int data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
