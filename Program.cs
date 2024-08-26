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
            if (tiencuoc>tien) {Console.WriteLine("Ban khong du tien de tiep tuc tro choi!");
            break;}
            

            Random rnd = new Random();
            int comp_num = rnd.Next(1,100);
            int man_num = 0;
            times++;

            for (int i = 0; i <5 ; i++) {
               
                    Console.Write("Your number: ");
                    man_num = int.Parse("0"+Console.ReadLine());

                    if (man_num == comp_num) {
                        Console.WriteLine("Bravo! You are Genius!");
                        Console.WriteLine($"So tien ban nhan duoc la: {tiencuoc}");
                        tien = tien + tiencuoc;
                        tiencuoc = 0; 
                        win++;
                        break;
                    }
                    else if (man_num < comp_num) Console.WriteLine("Your guessing number is less than computer number");
                    else Console.WriteLine("Your guessing number is greater than computer number");
                    tien = tien - tiencuoc / 5;
                    if (i==4) Console.WriteLine("You lose!");
                }
            
            Console.WriteLine($"The computer number is {comp_num}");
            Console.WriteLine();
            Console.WriteLine("Do you want to continue? Please text 'Y' or 'N' ");
            String res = ""+Console.ReadLine();
            if(res == "N") 
            {
            break;
            }
        } while (true);

        System.Console.WriteLine($"So lan da choi la: {times}");
        System.Console.WriteLine($"So lan thang la: {win}");
        System.Console.WriteLine($"So lan thua la: {times - win}");
        System.Console.WriteLine($"So tien con lai cua ban la: {tien}");
        System.Console.WriteLine("Bye! See you again!");
    }
}
