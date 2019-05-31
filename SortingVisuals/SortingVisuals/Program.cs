using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingVisuals
{
    class Program
    {
        static int window_width = 150;
        static int window_height = 150;
        public static RenderWindow window;

        static void Main(string[] args)
        {
            window = new RenderWindow(new VideoMode((uint)window_width, (uint)window_height), "SortingVisuals");
            window.Closed += new EventHandler(OnClose);

            BaseSort sort = new SelectionSort();
            sort.SetEntries(window_width, window_height);

            


            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.White);

                sort.DoSort();

                for (int i = 0; i < sort.GetCurrentSort().Count; i++)
                {
                    RectangleShape lineEntry = new RectangleShape(new SFML.System.Vector2f(1, sort.GetCurrentSort()[i]));
                    lineEntry.FillColor = Color.Black;
                    lineEntry.Position = new SFML.System.Vector2f(i, 0);
                    window.Draw(lineEntry);
                }
                

                

                window.Display();



            }
        }

        private static void OnClose(object sender, EventArgs e)
        {
            window.Close();
        }
    }
}
