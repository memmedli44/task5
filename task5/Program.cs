using System.Diagnostics.Metrics;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            ///*
            // * 1) 1-1000 qeder ededlerin cemi 7 bolunurmu?
            // */
            //int sum = 0;
            //int i;
            //for (i = 0; i < 1001; i++)
            //{
            //    sum += i;

            //}
            //if (sum % 7 == 0)
            //{
            //    Console.WriteLine("7-ye bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("7-ye bolunmur");
            //}
            #endregion

            #region Task 2
            ///*
            // * 2) 1-1000 qeder ededlerin icerisinde hem 7-e, hemde 8-e bolunenlerin siyahisi
            // */
            //int i;
            //for (i = 0; i < 1001; i++)
            //{
            //    if (i % 56 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            #endregion

            #region Task 3            
            ///*
            // * 3) 1 - 1000 qeder ederlerin icerisinden ele ededleri cap et ki, reqemleri cemi 3 - e bolunsun
            // */
            //int i, newnumber;

            //for (i = 0; i < 1001; i++)
            //{
            //    newnumber= i;
            //    int sum = 0;
            //    while (newnumber > 0) 
            //    {
            //        int remainder=newnumber % 10;
            //        newnumber /=10;
            //        sum += remainder;
            //    }
            //    if (sum % 3 != 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //} 

            #endregion

            #region Task 4
            /*
             * 4) 1-1000 qeder ederlerin icerisinden ele ededleri cap etki reqemleri cemi 3 e bolunsun ve sonuncu reqem 3 olmasin.
             */
            //int i, newnumber;
            //for (i = 0; i < 1001; i++)
            //{
            //    if (i % 10 != 3)
            //    {


            //        newnumber = i;
            //        int sum = 0;
            //        while (newnumber > 0)
            //        {
            //            int remainder = newnumber % 10;
            //            newnumber /= 10;
            //            sum += remainder;
            //        }
            //        if (sum % 3 != 0 )
            //        {

            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //}


            #endregion

            #region Task 5
            ///* 
            // * 5) 1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
            //      hem reqemleri cemi 5-e bolunsun,
            //      hem de ozu 5-e bolunsun
            //*/
            //int i, newnumber;
            //for (i = 0; i < 1001; i++)
            //{
            //    if (i % 5 == 0)
            //    {

            //        newnumber = i;
            //        int sum = 0;
            //        while (newnumber > 0)
            //        {
            //            int remainder = newnumber % 10;
            //            newnumber /= 10;
            //            sum += remainder;
            //        }
            //        if (sum % 5 == 0) 
            //        {

            //            Console.Write($"{i} ,");
            //        }


            //    }
            //}
            #endregion

            #region Task 6
            ///*
            // * 6)  1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
            //       hem ozu cut eded olsun,
            //       hem reqemleri cemi tek eded olsun,
            //       hem I reqemi tek eded olsun
            // */
            //int i, newnumber;
            //for (i = 0; i < 1001; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        if (i % 10 == 1)
            //        {
            //            newnumber = i;
            //            int sum = 0;
            //            while (newnumber > 0)
            //            {
            //                int remainder = newnumber % 10;
            //                newnumber /= 10;
            //                sum += remainder;
            //            }
            //            if (sum % 2 == 1)
            //            {

            //                Console.WriteLine(i);
            //            }

            //        }
            //    }             
            //}
            #endregion

            #region Task 7
            ///*
            // *7)  1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
            //       hemin ededin daxilinde 3 reqemi umumiyyetle olmasin
            // */
            //int i, newnumber;

            //for (i = 0; i < 1001; i++)
            //{
            //    bool stl;
            //    newnumber = i;

            //    while (newnumber > 0)
            //    {
            //        int remainder = newnumber % 10;

            //        newnumber /= 10;
            //        if (remainder == 3)
            //        {
            //            stl=true; 

            //            break;
            //        }
                    
            //    }
            //    if (false)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            #endregion
        }









    }
}

   
