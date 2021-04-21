using System.Collections.Generic;

namespace OblivionExample
{
    public interface IActiveEffectsVM
    {
        public List<IMagicListItemVM> Effects { get; set; }
        public string SpellEffectiveness { get; set; }
    }
}