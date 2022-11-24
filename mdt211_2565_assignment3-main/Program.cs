class Program
{
    static void Main(string[] args)
    {
                  

                Flower flower = new Flower();
                flower.mem1();    
                flower.mem2();    
        
    }  
 

}
class Flower
{
CircularLinkedList<char> PML = new CircularLinkedList<char>(); 

    public void mem1(){
        Input(x());
    } 
    char x(){
        Console.WriteLine("");
        Console.WriteLine("Input your flower (J/G/O/R)");
        return char.Parse(Console.ReadLine());
        
    }
     public void Input(char GetFlower){

      int range = PML.GetLength(); 
        while (true)
        {
           if (GetFlower == 'J')
            {
                if (range > 0)
                {
                    if (PML.Get(range-1) == 'R' && PML.Get(range-2) == GetFlower)
                    {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                    }
            
                    else
                    {
                        PML.Add(GetFlower);
                         
                    }
                }
                if (range == 0)
                {
                PML.Add(GetFlower);
                }
            mem1();    
            }

            if (GetFlower == 'G')
            {        

                if (range > 0)
                {
                    if (PML.Get(range-1) == 'R' && PML.Get(range-2) == GetFlower)
                    {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid pattern.");
                    }
                }    
                if (range > 2 )
                {
                    if (PML.Get(range-1) == GetFlower && PML.Get(range-2) == GetFlower && PML.Get(range-3) == GetFlower)
                    {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid pattern.");
                    }
                    if (PML.Get(0) == GetFlower && PML.Get(range-1) == GetFlower && PML.Get(range-2) == GetFlower)
                    {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid pattern.");
                    }
                    if (PML.Get(0) == GetFlower && PML.Get(1) == GetFlower && PML.Get(2) == GetFlower)
                    {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid pattern.");
                    }
                    else
                    {
                        PML.Add(GetFlower); 
                    }
                    }
                else
                {
                PML.Add(GetFlower);          
                }    
            mem1();        
            }
            
            if (GetFlower == 'O')
            {
                    if (range > 0)
                    {
                        if (PML.Get(range-1) == 'R' && PML.Get(range-2) == GetFlower)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                        }

                        else
                        {
                            PML.Add(GetFlower); 
                        }
                    }
               mem1(); 
            }

            if (GetFlower == 'R')

            {
                if (range < 1)
                {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern."); 
                }
                if (range > 0)
                {
                    if (PML.Get(range-1) == GetFlower && PML.Get(range-2) == GetFlower)
                    {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                    }
                    if (PML.Get(0) == GetFlower && PML.Get(range-3) == GetFlower)
                    {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                    }
                    if (range > 2)
                    {

                        if (PML.Get(range-1) == 'J' && PML.Get(0) == 'J')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                        }                     
                        if (PML.Get(range-1) == 'O' && PML.Get(0) == 'O')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                        }
                        if (PML.Get(range-1) == 'G' && PML.Get(0) == 'G')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid pattern.");
                        }                     
                            else
                            {
                            PML.Add(GetFlower); 
                            }                      
                    }
                        else
                        {
                            PML.Add(GetFlower); 
                        }
                        }
                mem1(); 
                }

            if (GetFlower != 'R' || GetFlower != 'G'  || GetFlower != 'O' || GetFlower != 'J'  )
            {
                break;
            }             
    }
    } 

    public void mem2(){
                Console.WriteLine("");
                int all = PML.GetLength();
                for (int i = 0; i < all; i++)
                {
                    Console.Write(PML.Get(i));
                }
    }
}
