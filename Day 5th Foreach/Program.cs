internal class Program
{
    private static void Main(string[] args)
    { /*
        int[] grades = new int[365];
        String[] daysofweek = new String[7];
        daysofweek[0] = "Poniedziałek";
        daysofweek[1] = "Wtorek";
        daysofweek[2] = "Środa";
        daysofweek[3] = "Czwartek";
        daysofweek[4] = "Piątek";
        daysofweek[5] = "Sobota";
        daysofweek[6] = "Niedziela";
        
        String[] daysofweek2 = { "Mon", "Tues", "Wed", "Thursday", "Fri", "Sat", "Sun" };
          
        for (var i = 0; i < daysofweek.Length; i++)
        {
            Console.WriteLine(daysofweek[i]);
        }
        for (var i = 0; i < daysofweek2.Length; i++)
        {
            Console.WriteLine(daysofweek2[i]);
        }
        List<string> daysofweek = new List<string>();
        daysofweek.Add("Poniedziałek");
        daysofweek.Add("Wtorek");
        daysofweek.Add("Środa");
        daysofweek.Add("Czwartek");
        daysofweek.Add("Piątek");
        daysofweek.Add("Sobota");
        daysofweek.Add("Niedziela");
        /* for (var i = 0; i < daysofweek.Count; i++)
         {
             Console.WriteLine(daysofweek[i]);
         }

        foreach (var day in daysofweek)
         {
             Console.WriteLine(day);
         }
        */
        //Zadanie Domowe
        var number = 433422009;
        
        String numberInSring = number.ToString();
        char[]  numbers = numberInSring.ToArray();
        int[] counters = { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        foreach (char singular in digits)
        {
            var count = 0;
            foreach (char c in numbers)
            {
                if (singular == c) count++;
            }
            Console.WriteLine(singular + " => " + count);
        }




        
       

    }
}