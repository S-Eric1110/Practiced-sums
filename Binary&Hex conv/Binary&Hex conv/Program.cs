namespace Binary_Hex_conv
{
    internal class Program
    {
    public static string binarynumberconvertor(int input)
        {
            string binary = "";
            while (input != 0)
            {
                int remainder = input % 2;
                int quotient = input / 2;
                binary = remainder+binary;
                input = quotient;
            }
            return binary;
        }
        public static string Hexconvertor(int input)
        {
            //string[] hexcharacters = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            Dictionary<int, string> result = new Dictionary<int, string>()
            {
                { 0, "0" },{1,"1"},
                {2,"2"}, {3,"3"},
                {4,"4"}, {5,"5"},
                {6,"6"},{7,"7"},
                {8,"8"},{9,"9"},
                {10,"A"},{11,"B"},
                {12,"C"},{13,"D"},
                {14,"E"},{15,"F"},
            };
            string hex = "";
            List<int> list = new List<int>();
            while (input != 0)
            {
                int remainder = input % 16;
                int quotient = input / 16;
                list.Add( remainder);
                input = quotient;
            }
            string finalhex = "";

            foreach(int n in list)
            {
               // Console.WriteLine(n);
                if (result.ContainsKey(n))
                {
                    finalhex = result[n] + finalhex;
                }
            }
            return finalhex;
        }
        //string hex = "";             ///another method for Hex convertion
        //    while (input != 0)
        //    {
        //        int remainder = input % 16;
        //int quotient = input / 16;

        //hex = hexcharacters[remainder]+hex;

        //        input = quotient;
        //    }
        //    return hex;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be converted to binary");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary Number is:"+binarynumberconvertor(n));
            Console.WriteLine("Hex number:"+Hexconvertor(n));
        }
    }
}
