using FiguresClassLibrary;
using ParsersLibrary;
using System;
using System.IO;
using System.Linq;

namespace FileExtensions
{
    public class FileReader
    {
        /// <summary>
        /// Reads figures data from a file
        /// </summary>
        /// <param name="path"></param>
        /// <returns>array of figures</returns>
        public Figure[] ReadFile(string path)
        {
            Figure[] figures;

           
                using (StreamReader sr = new StreamReader(path))
                {
                    int Count = File.ReadLines(path).Count();

                    figures = new Figure[Count];
                    Parser parser = new Parser();

                    string line;
                    int quantity = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split();

                        switch (data[0])
                        {

                            case "Rectangle":

                                figures[quantity] = parser.ParseAsRectangle(data);
                                quantity++;
                                break;

                            case "Triangle":

                                figures[quantity] = parser.ParseAsTriangle(data);
                                quantity++;
                                break;

                            case "Circle":

                                figures[quantity] = parser.ParseAsCircle(data);
                                quantity++;
                                break;

                        }      
                    }

                    return figures;
                }
            }
          
        }
    }

