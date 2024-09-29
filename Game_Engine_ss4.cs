internal class Program
{
    private const int V = 1000;

    private static void Main(string[] args)
    {
        game_engine();
    }
    private static void game_engine() {
        int tien = 1000;
        int tiencuoc = 0;
        int times =0, win = 0;
        
        do {
            Console.WriteLine($"The amount of your money: {tien}");
            Console.Write("You bet: "); 
            tiencuoc = int.Parse("0"+Console.ReadLine());
            if (tiencuoc>tien) {Console.WriteLine("You don't have enough money to continue the game!");
            break;}
            
            //Máy chọn số
            Random rnd = new Random();
            int comp_num = rnd.Next(1,100);
            int man_num = 0;
            times++;

            for (int i = 0; i <5 ; i++) {
               
                    Console.Write("Your number: "); //Bạn đoán số
                    man_num = int.Parse("0"+Console.ReadLine());

                    if (man_num == comp_num) {
                        Console.WriteLine("Bravo! You are Genius!");
                        Console.WriteLine($"The amount of money you received is: {tiencuoc}");
                        tien = tien + tiencuoc;
                        tiencuoc = 0; 
                        win++;
                        break;
                    }
                    else if (man_num < comp_num) Console.WriteLine("Your guessing number is less than computer number");
                    else Console.WriteLine("Your guessing number is greater than computer number");
                    if (i==4) Console.WriteLine("You lose!");
                }
            tien = tien - tiencuoc;

            Console.WriteLine($"The computer number is {comp_num}");
            Console.WriteLine();
            Console.WriteLine("Do you want to continue? Please text 'Y' or 'N' ");
            String res = ""+Console.ReadLine();
            if(res == "N") 
            {
            break;
            }
        } while (true);

        System.Console.WriteLine($"The number of times played is: {times}");
        System.Console.WriteLine($"The number of win times is: {win}");
        System.Console.WriteLine($"The number of lose times is: {times - win}");
        System.Console.WriteLine($"Your remaining amount is: {tien}");
        System.Console.WriteLine("Bye! See you again!");
    }
}