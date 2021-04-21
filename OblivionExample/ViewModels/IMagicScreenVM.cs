using System;
using System.Text;
using System.Windows.Controls;

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
}
