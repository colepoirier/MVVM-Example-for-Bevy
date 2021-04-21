using System.Collections.Generic;

namespace OblivionExample
{
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
}