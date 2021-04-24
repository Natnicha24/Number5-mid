using System;

namespace ws_midterm
{
    class Program
    {
        static void Main(string[] args)
        {//ข้อสาม ข้อมูลกล้อง
            string mode;
            mode = Console.ReadLine();
            float filmBackWidth;
            filmBackWidth = float.Parse(Console.ReadLine());
            if(filmBackWidth > 0)
            {
                float fLength, fov;
                if (mode == "fLength")
                {
                    do
                    {
                        fLength = float.Parse(Console.ReadLine());
                        if (fLength > 0)
                        {
                            Console.WriteLine("Invalid fLength.Please in put again.");
                           

                        }
                    } while (fLength < 0);

                    fov = 2 * Math.Atan(filmBackWidth / (2 * fLength));
                            Console.Write("fLength={0}", fLength);
                            Console.WriteLine(",fov={0}", fov);
                 }
                else if(mode=="fov"){
                    do
                    {
                        fov = float.Parse(Console.ReadLine());
                    } while (fov < 0.1 && fov > 6.28);
                    fLength = filmBackWidth / (2 * Math.Atan(fov / 2));
                    Console.Write("fLength={0}", fLength);
                    Console.WriteLine(",fov={0}", fov);

                }
            }
           else
            {
                Console.WriteLine("Invallid filmBackWidth.Please input again.");
              
            }

        }
    }
}
