class Program
{
    static void Main(string[] args)
    {
         CircularLinkedList<char> PML = new CircularLinkedList<char>(); 

        while (true)
        {
            int range = PML.GetLength(); 
            Console.WriteLine("Input your flower (J/G/O/R)");
            char SelectFlower = char.Parse(Console.ReadLine());

            if (SelectFlower != 'J' && SelectFlower != 'G' && SelectFlower != 'O' && SelectFlower != 'R' )
            {
                break;
            }
            else if  (SelectFlower == 'R')
            {
                if (PML.Get(range-1)== 'R' && PML.Get(range-2) == 'G') 
                {
                    Console.WriteLine("Invalid pattern.");
                }
            }
            else if (SelectFlower == 'G')
            {
                if (PML.Get(range-1)== 'R' && PML.Get(range-2)) 
                {
                    Console.WriteLine("Invalid pattern.");
                }
            }
            else
            {
                PML.Add(SelectFlower);
            }
        }
    }
}