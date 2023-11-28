namespace Exercises.Items
{
    public class OOPProj18 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-18: Main Class";
        class Item
        {
            private string _name;
            private DateTime _createdAt;

            public Item(string name)
            {
                // write code here
                _name = name;
                _createdAt = DateTime.Now;
            }

            public override string ToString()
            {
                // write code here
                return $"{_name} (created at: {_createdAt})";
            }

        }

        public override void Run()
        {
            List<Item> items = new List<Item>();
            Console.WriteLine("Input name item. Press Enter to exit: ");
            while (true)
            {
                Console.Write("Name: ");
                string nameItem = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(nameItem))
                {
                    break;
                }
                else
                {
                    Item newItem = new Item(nameItem);
                    items.Add(newItem);
                }
            }
            Console.WriteLine("Items: ");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
