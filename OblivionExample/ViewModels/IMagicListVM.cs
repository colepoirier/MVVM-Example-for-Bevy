using System.Collections.Generic;

namespace OblivionExample
{
    public interface IMagicListVM
    {
        public List<IMagicListItemVM> GreaterPowers { get; set; }
        public List<IMagicListItemVM> Spells { get; set; }
        public List<IMagicListItemVM> Scrolls { get; set; }
        public string SpellEffectiveness { get; set; }
    }
}