namespace ReverseString
{
    internal class Program
    {
        // Time Complexity: O(n)
        //Space Compilexity: O(n)
        static public void ReverseString(char[] s)
        {
            char[] Result = new char[s.Length];
            int count = 0;
            for(int i=s.Length-1; i>=0; i--)
            {
                Result[count] = s[i];
                    count++;
            }
            for(int i=0; i<s.Length; i++)
            {
               s [i] =Result[i];               
            }
                
        }

        static void Main(string[] args)
        {
            char[] input = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(input);
            Console.Write("[");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                if(i<input.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("]");
        }
    }
}
