using System;



namespace Inverse_Hello_world

{

    class Program

    {

        static void Main(string[] args)

        {

            string helloWorld =  "Hello World!";

            int charCount = "Hello World!".Length;

            Char[] caracteresHello = new char [charCount];



            //for(int n = 0; n <charCount; n++){

            //Console.WriteLine(helloWorld[n]);}



            //Console.WriteLine(helloWorld.Substring(0,5));

            

           







            for (int i = 0; i < helloWorld.Length; i++) {

            Console.WriteLine(helloWorld[i]);

            int newIndex = (helloWorld.Length - 1) - i;

            caracteresHello[newIndex] = helloWorld[i];

}

            Console.WriteLine(caracteresHello);



        

        }

    }

}