using FiguresClassLibrary;
using System.Linq;

namespace FiguresLibrary
{
    public class FigureActions
    {
        /// <summary>
        /// Finds all duplicate array members 
        /// </summary>
        /// <param name="figure"></param>
        /// <param name="array"></param>
        /// <returns>array of duplicates</returns>
        public Figure[] GetSameFiguresArray(Figure figure, Figure[] array) => (from data in array where data.Equals(figure) select data).ToArray();
        
    }
}
