using System;
using System.Text.Json;

namespace MasteringLINQ
{
    public static class Extension
    {
        public static void Print(this object o)
        {
            if (o is string)
            {
                Console.WriteLine(o);
            }
            else
            {
                Console.WriteLine(JsonSerializer.Serialize(o, options: new JsonSerializerOptions { WriteIndented = true }));
            }
        }
    }
}
