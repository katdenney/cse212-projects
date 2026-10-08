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
        //base case dont insert duplicate
        if (value == Data)
        {
            return;
        }//dont insert duplicate

        if (value < Data)
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
        //base case value found
        if (value == Data)
        {
            return true;
        }
        if (value < Data)// search tree left 
        {
            if (Left is null)
                return false;

            return Left.Contains(value);
        }
        else//search right
        {
            if (Right is null)
                return false;
            return Right.Contains(value);
        }
        
        
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = 0;
        int rightHeight = 0;
        //get left height 
        if (Left !=null)
        {
            leftHeight = Left.GetHeight();
        }
        //get right height
        if (Right !=null)
        {
            rightHeight = Right.GetHeight();
        }

        // Replace this line with the correct return statement(s)
        return 1+ Math.Max(leftHeight, rightHeight);
    }
}