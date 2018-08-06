using System;
using System.Collections.Generic;

namespace Week_2_task
{
    class Program
    {
        static void Main(string[] args)
        { 
			List<int> Prime = new List<int>();

			int a = 0;
			int b = 1;
			int c;
			int sum = 0;

			int counter = 8;

            while(counter > 0)
			{
				c = a + b;

                if(c != 1)
				{
					if(c == 2)
					{
						sum += c;
						counter--;
					}

					else{

						int i;
						bool IsPrime = false;



						for (i = 2; i < c; i++)
                        {
                            if (c % i == 0)
                            {
								IsPrime = true;
                                break;
                            }

                        }

						if (IsPrime == false)
                        {
							Prime.Add(c);
							sum += c;
							counter--;
                        }
					}
				}

				a = b;
				b = c;
			}


            foreach(int p in Prime)
			{
				Console.WriteLine(p);

			}

			Console.WriteLine(sum);
        }
    }
}
