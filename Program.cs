namespace Random_number
{
    internal class Program
    {

        public static void FillArrayRandomNumber( ref int[] arr,ref int len) 
        {
            arr = new int[100];
            Random random= new Random();
           
            Console.WriteLine("Enter  the number of elemnt in array");
            len = int.Parse(Console.ReadLine());

            for(int i=0; i < len; i++) 
            {
                arr[i] = random.Next(1,100);
            
            }
          



        }

        public static void PrintAllUnmbers(int[]arr,  int len ) 
        {
           

            for(int i=0; i < len; i++) 
            {
                Console.Write(arr[i]+" ");
            
            }
        
        }

    
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int len=5;
          
            FillArrayRandomNumber(ref arr,ref len);

            PrintAllUnmbers( arr, len);
        }
    }
}