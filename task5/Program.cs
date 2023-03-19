using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.WebSockets;

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
            //for (i = 1; i < 1001; i++)
            //{
            //    if (i % 56 == 0)
            //    {
            //        Console.WriteLine(i);


            //    }
            //}

            #endregion

            #region Task 3            
            ///*
            // * 3) 1 - 1000 qeder ederlerin icerisinden ele ededleri cap et ki, reqemleri cemi 3 - e bolunsun
            // */
            //int i, newnumber;

            //for (i = 0; i < 1001; i++)
            //{
            //    newnumber = i;
            //    int sum = 0;
            //    while (newnumber > 0)
            //    {
            //        int remainder = newnumber % 10;
            //        newnumber /= 10;
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
            //int i, newnumber , scndNumber;
            //for (i = 0; i < 1001; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        int lastRemaider = 0;
            //        scndNumber= i;
            //        while (scndNumber > 0)
            //        {
            //            int remainder= scndNumber%10;
            //            scndNumber /= 10;
            //            lastRemaider = remainder;
            //        }
            //        if (lastRemaider % 2== 1)
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
            //    bool stl=false;
            //    newnumber = i;

            //    while (newnumber > 0)
            //    {
            //        int remainder = newnumber % 10;

            //        newnumber /= 10;
            //        if (remainder == 3)
            //        {
            //            stl = true;

            //            break;
            //        }

            //    }
            //    if (!stl)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            #endregion

            #region Task 8
            ///*           
            //  8)  1-1000 qeder ederlerin icerisinden,
            //    daxilinde 3 reqemi olmayib,
            //    reqemleri cemi 3 olan en sonuncu eded hansidir?
            //*/
            //int result = 0;
            //for (int i = 0; i < 1001; i++)
            //{
            //l1:
            //    int sum = 0;
            //    int number = i;
            //    bool stl = false;
            //    while (number > 0)
            //    {
            //        int remainder = number % 10;
            //        number /= 10;
            //        if (remainder == 3)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum += remainder;
            //    }
            //    if (sum == 3)
            //    {
            //        result= i;
            //    }         




            //}
            //Console.WriteLine( result);
            #endregion

            #region Task 9
            ///*
            // * 9)  1-1000 qeder ederlerin icerisinde
            //        11-e bolunub reqemleri cemi 11-den boyuk olan 11-ci eded hansidir?
            // */
            //int contains = 0;
            //int result = 0;
            //for (int i = 0; i < 1001; i++)
            //{

            //    int number = i;
            //    int sum = 0;
            //    if (i % 11 == 0)
            //    {
            //        while (number > 0)
            //        {
            //            int remainder = number % 10;
            //            number /= 10;
            //            sum += remainder;

            //        }
            //        if (sum > 11)
            //        {

            //            contains++;
            //            result = i;
            //        }

            //        if (contains == 11)
            //        {
            //            Console.WriteLine(result);
            //        }

            //    }


            //}
            #endregion

            #region Task 10
            ///*10) 1-1000 qeder CUT ederlerin icerisinde
            //  reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
            //*/
            //int result = 0;
            //for(int i=0;i<1001;i++)
            //{               
            //    if(i%2==0)                    
            //    {
            //        int newNubmer = i;
            //        int sum = 0;

            //        while(newNubmer > 0)
            //        {
            //            int remainder=newNubmer%10;
            //            newNubmer /= 10;
            //            sum += remainder;



            //        }
            //        if (sum > 5 && sum < 7)
            //        {
            //            if (result < i)
            //            {
            //                result = i;
            //            }
            //            Console.WriteLine(result);
            //        }
            //    }


            //}
            //Console.WriteLine($": en boyuk {result}");
            #endregion

            #region Task 11
            ///*11) 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki:
            //    hem polindrom olsun,
            //    hem ededin reqemleri daxilinde 3 olmasin
            //    hem ededin reqemleri cemi 10 dan boyuk olsun
            //*/
            //for(int i=0;i<1001;i++)
            //{
            //    l1:
            //    int example = i;
            //    int sum = 0;
            //    while(example > 0)
            //    {
            //        int remainder = example % 10;
            //        example/= 10;
            //        if(remainder==3)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum+= remainder;
            //    }
            //    if(sum > 10) 
            //    {
            //        int reverse = 0;
            //        int number = i;
            //        while(number > 0)
            //        {
            //            int remainder = number % 10;
            //            number/= 10;
            //            reverse = reverse * 10 + remainder;
            //        }
            //        if(reverse==i)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }

            //}
            #endregion

            #region Task 12
            ///* 12) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
            //      hem butun reqemleri eyni olsun,
            //      hem reqemleri cemi 5 den boyuk olsun
            //      hem reqemleri arasinda 5 reqemi olmasin                          
            //*/

            //for (int i=10;i<100001;i++)
            //{
            //l1:
            //    int result = 0;
            //    if (i < 100001)
            //    {

            //        int example = i;
            //        int sum = 0;
            //        while (example > 0)
            //        {
            //            int remainder = example % 10;
            //            example /= 10;
            //            if (remainder == 5)
            //            {
            //                i++;
            //                goto l1;
            //            }
            //            sum += remainder;
            //        }
            //        if (sum < 5) 
            //        {
            //            i++;
            //            goto l1;

            //        }

            //        int number = i;
            //        int firstNumber = number % 10;

            //        while (number > 0)
            //        {
            //            int remainder = number % 10;
            //            number /= 10;
            //            if (firstNumber != remainder)
            //            {

            //                i++;
            //                goto l1;
            //            }
            //        }                                   
            //    }
            //    Console.WriteLine(i);
            //}            
            #endregion

            #region Task  13
            ///*13) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
            //      hem butun reqemleri yalniz tek ededlerden ibaret olsun,
            //      polindrom olsun,
            //      daxilinde minimum 1 dene 5 reqemi olsun
            //*/
            //for (int i=1;i<100001;i++)
            //{
            //l1: 
            //    bool stiuate = true;
            //    int result = 0;
            //    int number = i;                
            //    int reverse = 0;
            //    while (number > 0)
            //    {
            //        int remainder = number % 10;
            //        number/= 10;
            //        if(remainder%2==0)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        reverse = reverse * 10 + remainder;
            //    }
            //   // Console.WriteLine(i);
            //    if (reverse!=i)
            //    {
            //        i++;
            //        goto l1;    
            //    }
            //    int numberTwo = i;

            //    //Console.WriteLine(i);
            //    while (numberTwo > 0)
            //    {
            //        int remainder = numberTwo % 10;
            //        numberTwo /= 10;
            //        if (remainder == 5)
            //        {
            //            stiuate = true;
            //            result = i;
            //            break;


            //        }
            //        else
            //        {
            //            stiuate = false;
            //        }
            //    }
            //    if (stiuate ) 
            //    {
            //        Console.WriteLine(result);

            //    }
            //}

            #endregion

            #region Task  14
            ///*14) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
            //      hem ededin ozunun daxilinde 2 dene yanashi gelen 1 reqemi olsun
            //      hem ededin reqemleri cemi 7- 15 arasinda olsun.
            //      hem ededin reqemlerinin daxilinde 6 reqemi olmasin
            //      hem ededin ozunun daxilinde minimum 2 dene 5 olsun,
            //*/
            //for (int i = 1; i < 100001; i++)
            //{
            //l1:
            //    bool stiuate = true;         
            //    int number = i;
            //    int numberThree = 0;
            //    int lastNumber = 0;
            //    int sum = 0;
            //    while (number > 0)
            //    {
            //        int remainder = number % 10;
            //        number /= 10;
            //        if (remainder % 6 == 0)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum += remainder;
            //    }
            //    // Console.WriteLine(i);
            //    if (sum <= 7 || sum>=15)
            //    {
            //        i++;
            //        goto l1;
            //    }
            //    int numberTwo = i;

            //    //Console.WriteLine(i);
            //    while (numberTwo > 0)
            //    {
            //        int remainder = numberTwo % 10;
            //        numberTwo /= 10;
            //        if (remainder == 1)
            //        {
            //            if (numberTwo % 10 == 1) 
            //            {
            //                stiuate = true;
            //                numberThree = i;
            //            }

            //        }

            //    }
            //    //Console.WriteLine(numberThree);
            //    bool resultStl = true;
            //    if (stiuate)
            //    {
            //       // Console.WriteLine(numberThree);
            //        //i = numberThree;

            //        while (numberThree > 0)
            //        {
            //            int remainder = numberThree % 10;
            //            numberThree /= 10;
            //            lastNumber= numberThree;
            //            if (remainder == 5)
            //            {
            //                while (lastNumber > 0)
            //                {
            //                    int remainderTwo=lastNumber% 10;
            //                    lastNumber /= 10;
            //                    if(remainderTwo==5)
            //                    {

            //                        resultStl = false;

            //                        break;

            //                    }

            //                }
            //            }
            //        }
            //    }
            //    if(!resultStl) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region task 15
           // /*15)*1 - 10000 qeder ederlerin icerisinden ele ededleri cap etki:
           //       hem sade eded olsun
           //       hem ededin ozunun daxilinde 0,1,5,7,9 reqemleri olmasin
           //       hem ededin reqemleri ceminde 2 reqemi olmasin 
           // */
           // int[] number = { 0, 1, 5, 7, 9 };
           // for (int i = 1; i < 10001; i++)
           // {
           //l1:
           //     for (int j = 2; j <= i / 2; j++)
           //     {
           //         if(i%j==0)
           //         {
           //             i++;
           //             goto l1;
           //         }
           //     }
           //     //Console.WriteLine(i);
           //     int step = i;
           //     int sum = 0;
           //     while(step > 0)
           //     {
           //         int remainder = step % 10;
           //         step/= 10;
           //         if (Array.IndexOf(number, remainder) != -1)
           //         {
           //             i++;
           //             goto l1;
           //         }
           //         sum+= remainder;
           //     }
           //     while (sum > 0)
           //     {
           //         int remainder = sum % 10;
           //         sum/= 10;
           //         if (remainder == 2)
           //         {
           //             i++;
           //             goto l1;
           //         }
           //     }
           //     Console.WriteLine(i);
           // }   
            #endregion

        }
    }
}

   
