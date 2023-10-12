namespace Skogen2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal0 = new Animal("vargen", true, " smyger omkring och letar efter sitt byte");
            Animal animal1 = new Animal("faldermusen", true, " flyger bland träden i jakt på mat ");

            Animal animal2 = new Animal("hästen", false, " springer runt i stallet");
            Animal animal3 = new Animal("fåret", false, " äter sitt gräss från marken");

            List<Animal> animals = new List<Animal>

            {
                
                  animal0 ,animal1, animal2, animal3
               
            };

            bool night = false;

             

            while(true)
            {

                ConsoleKeyInfo key = Console.ReadKey(); // tar in inmatning
                Console.Clear();
                foreach(Animal animal in animals) // här loppar jag djuren
                {

                    if(key.KeyChar == 'd') // om man trycker på d så skrivs ut djuren som är ute under dagen
                    {
                        night = false;
                    }
                    
                    else if(key.KeyChar == 'n')
                    {
                        night = true;
                    }
                    
                        
                    // if-satsen och switchen gör samma sak.

                    //switch(key.KeyChar)
                    //{
                    //    case 'd':
                    //        night = false;
                    //        break;
                    //    case 'n':
                    //        night = true;
                    //        break;
                    //}
                     
                    if (night)
                    {

                        Console.WriteLine(animal.Name  + (animal.Nocturnal ? animal.Movement : " sover"));





                    }

                    else
                    {

                        Console.WriteLine(animal.Name + (!animal.Nocturnal ? animal.Movement : " sover"));
                    }

                  

                }

                 Console.WriteLine("--------------------------------------------------------------");






            }


        }
    }
}