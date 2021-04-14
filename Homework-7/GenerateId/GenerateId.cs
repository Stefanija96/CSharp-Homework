using System;

namespace GenerateId
{
    public class GenerateId
    {
        public static int RandomId()
        {
            int id = new Random().Next(1, 10);

            return id;
        }
    }
}
