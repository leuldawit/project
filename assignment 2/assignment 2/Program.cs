class assigment2 {

    static void Main(string[] args)
    {
        int number, sum = 0, no;
        Console.WriteLine("enter how many numbers you want to add");

       no = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < no; i++) {
            Console.Write("Enter  Number " + i + 1);

            number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                do {
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please Enter Positive Number");
                
                } while (number < 0) ;
            }

             sum += number;
        }
        Console.WriteLine("The sum is " + sum);
       
    }
}