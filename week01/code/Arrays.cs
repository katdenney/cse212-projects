public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static void Run() {
        //define the run method
        //---------------------
        //variable declaration
        //variable initialization
        //call the multiplesOf method with starting number parameter and length parameter (how many multiples of number)
        var multiples = MultiplesOf(7, 5);
        //print the multiples of number to console as double array
        Console.WriteLine("double[]{{{0}}}", string.Join(", ", multiples));  
        
        //create new list called data
        //variable declaration
        //variable initialization
        List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //call the RotateListRight method with "data" list and amount of index to rotate
        RotateListRight(data, 3);
        //print the data list that has been modified
        Console.WriteLine("List<int>{{{0}}}", string.Join(",", data));
    }
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        //--------------------------------------------
        //create new double array with size of "length"
        double[] result = new double [length];  
        //for loop iterate through array index 0 to "length"
        for (int i = 0; i <length; i++) 
        {
        //set each index to number * iteration +1 to get multiples of the number parameter
          result[i] = number * (i + 1);    
        }
        //return the result array                 
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        //use GetRange method get the last amount elements of the list and store them in a temporary list
        var temp = data.GetRange(data.Count - amount,amount);
        //remove the elements from the OG list use RemoveRange method
        data.RemoveRange(data.Count - amount, amount);
        //put temp elements at the beginning use InsertRange method
        data.InsertRange(0, temp);



    }
}
