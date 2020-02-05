using System;



namespace subroutines_with_password

{

    class Program

    {

        static void Main(string[] args)

        {

            string Password;

            Console.WriteLine("Type in your password, it must contain 3 numbers 3 capital letters and 3 lower case letters at minimun");







            Password = Console.ReadLine();



            passwordvalidation(Password);



        }

        public static bool passwordvalidation(string s)

        {

            int Lowcase = 0;

            int Caps = 0;

            int number = 0;

            Console.WriteLine(s.Length);

            for (int j = 0; j < s.Length; j = j + 1)

            {

                if (s[j] >= 'A' && s[j] <= 'Z')

                {



                    Caps = Caps + 1;





                }
                if (s[j] >= '0' && s[j] <= '9')
                {
                    number = number + 1;
                }
                if (s[j] >= 'a' && s[j] <= 'z')
                {
                    Lowcase = Lowcase + 1;
                }
















            }

            Console.WriteLine(Caps);


            if (Lowcase >= 3 && number >= 3 && Lowcase >= 3)
            {
                Console.WriteLine("True");
                return true;

            }
            else
            {
                Console.WriteLine("False");

                return false;

            }




        }
    }

}



     