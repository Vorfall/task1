using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace epam_task_1
{
    public class EuclidMethods
    {
        /// <summary>
        /// Calculates gdc(a,b)
        /// if a or b is negative value - throws expetion
        /// as an addition - calculates a time of an execution
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="time"></param>
        /// <returns>gdc result</returns>
        public int GetGDCEuclideanMethod(int a, int b, out long time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            if (a == 1 || b == 1)
            {

                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return 1;
            }

            if (a == 0)
            {
                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return b;
            }

            if (b == 0)
            {
                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return a;
            }

            if (a < 0)
            {
                a = Math.Abs(a);
            }

            if (b < 0)
            {
                b = Math.Abs(b);
            }


            if (a == 0)
            {
                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return b;
            }

            if (b == 0)
            {
                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return a;
            }

            if (a == b)
            {
                timer.Stop();
                time = timer.ElapsedMilliseconds;

                return a;
            }



            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            timer.Stop();

            time = timer.ElapsedMilliseconds;

            return a > b ? a : b;
        }

        /// <summary>
        /// Calculates gdc(gdc(a,b), c)
        /// simply calls original method n-times
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="time"></param>
        /// <returns>gdc result</returns>
        public int GetGDCEuclideanMethod(int a, int b, int c, out long time)
        {
            long allTime = 0;

            int gdcAB = GetGDCEuclideanMethod(a, b, out time);

            allTime += time;

            return GetGDCEuclideanMethod(gdcAB, c, out allTime);
        }

        /// <summary>
        /// gdc(gdc(a,b),gdc(c,d))
        /// simply calls original method n-times
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="time"></param>
        /// <returns>gdc result</returns>
        public int GetGDCEuclideanMethod(int a, int b, int c, int d, out long time)
        {
            long allTime = 0;

            int gdcAB = GetGDCEuclideanMethod(a, b, out time);

            allTime += time;

            int gdcCD = GetGDCEuclideanMethod(c, d, out time);

            allTime += time;

            return GetGDCEuclideanMethod(gdcAB, gdcCD, out allTime);

        }

        /// <summary>
        /// gdc(gdc(gdc(a,b),gdc(c,d)), e)
        /// simply calls original method n-times
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="е"></param>
        /// <param name="time"></param>
        /// <returns>gdc result</returns>
        public int GetGDCEuclideanMethod(int a, int b, int c, int d, int е, out long time)
        {
            long allTime = 0;

            int gdcAB = GetGDCEuclideanMethod(a, b, out time);

            allTime += time;

            int gdcCD = GetGDCEuclideanMethod(c, d, out time);

            allTime += time;

            int gdcABCD = GetGDCEuclideanMethod(gdcAB, gdcCD, out time);

            allTime += time;

            return GetGDCEuclideanMethod(gdcABCD, е, out allTime);

        }
        /// <summary>
        /// Calculates gdc(a,b) but by using Steins method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="time"></param>
        /// <returns>gdc result</returns>
        public int GetGCDStain(int a, int b, out long time)
        {
            bool parityСheck(int number)
            {
                return (number % 2) == 1 ? false : true;
            }

            Stopwatch timer = new Stopwatch();
            timer.Start();

            if (a == 1 || b == 1)
            {

                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return 1;
            }

            if (a == 0)
            {
                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return b;
            }

            if (b == 0)
            {
                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return a;
            }

            if (a < 0)
            {
                a = Math.Abs(a);
            }

            if (b < 0)
            {
                b = Math.Abs(b);
            }


            if (a == 0)
            {
                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return b;
            }

            if (b == 0)
            {
                timer.Stop();

                time = timer.ElapsedMilliseconds;

                return a;
            }

            if (a == b)
            {
                timer.Stop();
                time = timer.ElapsedMilliseconds;

                return a;
            }


            int count = 1;
            while (a != 0 && b != 0)
            {
                while (parityСheck(a) && parityСheck(b))
                {
                    a /= 2;
                    b /= 2;

                    count *= 2;
                }

                while (parityСheck(a))
                {
                    a /= 2;
                }

                while (parityСheck(b))
                {
                    b /= 2;
                }

                if (a >= b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            timer.Stop();
            time = timer.ElapsedMilliseconds;

            return count * b;
        }

        /// <summary>
        /// collects execution time of the all methods below and creates dictionary for a histogramm usage
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>dictionary with results</returns>
        public Dictionary<string, long> GetTimeCalculatuions(int a, int b, int c, int d, int е)
        {
            Dictionary<string, long> dataToPass = new Dictionary<string, long>();

            long time2Parameters;
            long time3Parameters = 0;
            long time4Parameters = 0;
            long time5Parameters = 0;
            long timeStain2 = 0;

            GetGDCEuclideanMethod(a, b, out time2Parameters);
            GetGDCEuclideanMethod(a, b, c, out time3Parameters);
            GetGDCEuclideanMethod(a, b, c, d, out time4Parameters);
            GetGDCEuclideanMethod(a, b, c, d, е, out time5Parameters);
            GetGCDStain(a, b, out timeStain2);

            dataToPass.Add("for 2 parameters GDC is", time3Parameters);
            dataToPass.Add("for 3 parameters GDC is", time3Parameters);
            dataToPass.Add("for 4 parameters GDC is", time4Parameters);
            dataToPass.Add("for 5 parameters GDC is", time5Parameters);
            dataToPass.Add("GCD Stain 2 parameters", timeStain2);

            return dataToPass;
        }
    }
}
