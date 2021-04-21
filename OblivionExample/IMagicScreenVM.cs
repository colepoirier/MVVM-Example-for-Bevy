using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace OblivionExample
{
    public interface IMagicScreenVM
    {
        public IMagicListVM AllMagic { get; set; }
        public IMagicListVM Potions { get; set; }
        public IMagicListVM TouchMagic { get; set; }
        public IMagicListVM SelfMagic { get; set; }
        public IActiveEffectsVM ActiveEffects { get; set; }
        public int SelectedTabIndex { get; set; }
    }

    public interface IMagicListVM
    {
        public List<IMagicListItemVM> GreaterPowers { get; set; }
        public List<IMagicListItemVM> Spells { get; set; }
        public List<IMagicListItemVM> Scrolls { get; set; }
        public string SpellEffectiveness { get; set; }
    }

    public interface IMagicListItemVM
    {
        public string Name { get; set; }

        public ImageSource Image { get; set; }

        public float ManaCost { get; set; }

        public bool IsHighlighted { get; set; }

        public bool IsSelected { get; set; }
    }

    public interface IActiveEffectsVM
    {
        public List<IMagicListItemVM> Effects { get; set; }
        public string SpellEffectiveness { get; set; }
    }

}
