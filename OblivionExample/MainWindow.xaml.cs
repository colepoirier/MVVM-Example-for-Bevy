using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OblivionExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ExampleScreen();
        }
    }

    public class ExampleScreen : IMagicScreenVM
    {
        public IMagicListVM AllMagic { get; set; } = new ExampleList();
        public IMagicListVM Potions { get; set; } = new ExampleList();
        public IMagicListVM TouchMagic { get; set; } = new ExampleList();
        public IMagicListVM SelfMagic { get; set; } = new ExampleList();
        public IActiveEffectsVM ActiveEffects { get; set; } = null;
        public int SelectedTabIndex { get; set; }
    }

    public class ExampleList : IMagicListVM
    {
        public List<IMagicListItemVM> GreaterPowers { get; set; }
        public List<IMagicListItemVM> Spells { get; set; }
        public List<IMagicListItemVM> Scrolls { get; set; }
        public string SpellEffectiveness { get; set; } = "Spell effectiveness: 97%";

        public ExampleList()
        {
            GreaterPowers = new List<IMagicListItemVM>()
            {
                new ExampleItem("Dragon Skin", 0),
                new ExampleItem("Gift of the Arch Mage", 0),
            };

            Spells = new List<IMagicListItemVM>()
            {
                new ExampleItem("Ease Burden", 38),
                new ExampleItem("Heat Shell", 50),
                new ExampleItem("Corpse Carry", 1),
                new ExampleItem("Flare", 17),
            };

            Scrolls = new List<IMagicListItemVM>()
            {
                new ExampleItem("Frost Shell", 14),
            };
        }
    }

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
