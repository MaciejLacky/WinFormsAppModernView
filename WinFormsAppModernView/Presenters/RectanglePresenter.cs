using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppModernView.Views;
using WinFormsAppModernView.Models;
using Rectangle = WinFormsAppModernView.Models.Rectangle;

namespace WinFormsAppModernView.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;

        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = double.Parse(rectangleView.LengthText);
            rectangle.Width = double.Parse(rectangleView.WidthText);

            rectangleView.AreaText = rectangle.CalculateArea().ToString();
        }

    }
}
