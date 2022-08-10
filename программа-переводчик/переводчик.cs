namespace программа_переводчик
{
    internal class переводчик
    {
        static void Main(string[] args)
        {

            Console.WriteLine("программа-переводчик");
            var dictionary = new Dictionary<string, string>()
            {
                ["passion"] = "страсть",
                ["smile"] = "улыбка",
                ["eternity"] = "вечность",
                ["fantastic"]="фантастический",
                ["liberty"]="свобода",
                ["tranquility"]="спкойствие",
                ["love"]="любовь",
                ["mother"]="мама",
                ["asphodel"]="нарцисс",
                ["fawn"]="олененок"                     
               };
            while (true)
            {
                Console.WriteLine("введите слово на английском");
                var input = Console.ReadLine();
                Console.WriteLine(dictionary.ContainsKey(input) ? dictionary[input] : "такого слова нет в словаре");
                //if (dictionary.ContainsKey(input))                
                //    Console.WriteLine(dictionary[input]);                
                //else
                //    Console.WriteLine("такого слова нет в словаре");
            }

        }
    }
}