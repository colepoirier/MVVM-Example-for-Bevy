using System.Windows.Media;

namespace OblivionExample
{
    public interface IMagicListItemVM
    {
        public string Name { get; set; }

        public ImageSource Image { get; set; }

        public float ManaCost { get; set; }

        public bool IsHighlighted { get; set; }

        public bool IsSelected { get; set; }
    }
}