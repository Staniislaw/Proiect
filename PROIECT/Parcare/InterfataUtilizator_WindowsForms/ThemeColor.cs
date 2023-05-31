using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InterfataUtilizator_WindowsForms
{

    public static class ThemeColor
    {
        public static Color primaryColor {  get; set; }
        public static Color secondaryColor { get; set; }
        public static List<string> ColorList = new List<string>()
    {
        "#800080" ,//(purpuriu închis)
        "#008000" ,//(verde închis)
        "#000080" ,//(albastru închis)
        "#808000", //(olivă închis)
        "#008080" ,//(turcoaz închis)
        "#A52A2A",// (maro)
        "#9932CC",// (violet mediu)
        "#228B22",// (verde pădure)
        "#1E90FF" ,//(albastru cer)
        "#D2691E" ,//(mărărui)
        "#FF7F50" ,//(portocaliu piersică)
        "#B8860B",// (chihlimbar)
        "#8B008B",// (mov închis)
        "#006400" ,//(verde întunecat)
        "#00008B",// (albastru marin)
};


        // metoda de a schimba luminozitatea culorii
        public static Color ChangeBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //daca correctionFactor ii mai mic decat 0 ,culoare inchisa
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //altfel culoarea va fi deschisa
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                red = (255 - red) * correctionFactor + red;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }   
}