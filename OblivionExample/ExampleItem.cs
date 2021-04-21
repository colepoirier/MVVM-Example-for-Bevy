using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace OblivionExample
{
    public class ExampleItem : IMagicListItemVM
    {
        public string Name { get; set; }
        public ImageSource Image { get; set; }
        public float ManaCost { get; set; }
        public bool IsHighlighted { get; set; }
        public bool IsSelected { get; set; }

        public ExampleItem(string name, float manaCost)
        {
            Name = name;
            ManaCost = manaCost;
            var uri = new Uri(@"C:\Users\DVD\Pictures\tiling.png");
            Image = new BitmapImage(uri);
        }
    }
}