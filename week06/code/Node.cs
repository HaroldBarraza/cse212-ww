public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {
            return;
        }

        else if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            if (Left is null)
            {
                return false;
            }
            else
            {
                return Left.Contains(value);
            }
        }
        else
        {
            if (Right is null)
            {
                return false;
            }
            else
            {
                return Right.Contains(value);
            }
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left is null && Right is null)
        {
            return 1;
        }

        int leftHeight = (Left != null) ? Left.GetHeight() : 0;
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;
        return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }
}