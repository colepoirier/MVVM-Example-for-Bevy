namespace OblivionExample
{
    public class ExampleScreen : IMagicScreenVM
    {
        public IMagicListVM AllMagic { get; set; } = new ExampleList();
        public IMagicListVM Potions { get; set; } = new ExampleList();
        public IMagicListVM TouchMagic { get; set; } = new ExampleList();
        public IMagicListVM SelfMagic { get; set; } = new ExampleList();
        public IActiveEffectsVM ActiveEffects { get; set; } = null;
        public int SelectedTabIndex { get; set; }
    }
}