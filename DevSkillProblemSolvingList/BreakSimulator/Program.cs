using System;

namespace BreakSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            float finalVelocity = 0.0f;
            int testcase = int.Parse(Console.ReadLine());
            if (testcase >= 1 && testcase <= 50)
            {
                for (int i = 0; i < testcase; i++)
                {
                    var inputs = Console.ReadLine().Split(' ');
                    float initialVelocity = float.Parse(inputs[0]);
                    float time = float.Parse(inputs[1]);

                    if ((initialVelocity >= 20.0 && initialVelocity <= 1000.0) && (time >= 2.0 && time <= 200.0))
                    {
                        float result = (float)Math.Round(((finalVelocity - initialVelocity) / time), 2);


                        var aninputs = result.ToString().Split('.');
                        if (aninputs.Length > 1)
                        {
                            if (aninputs[1].Length == 1)
                            {
                                Console.WriteLine(result + "0");
                            }
                            else
                                Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine(result + ".00");
                        }
                    }
                }

            }
        }
    }
}
