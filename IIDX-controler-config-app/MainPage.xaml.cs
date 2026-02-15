using System.Collections.ObjectModel;

namespace IIDX_controler_config_app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public ObservableCollection<Key> KeyOptions { get; } = new ObservableCollection<Key> {
            new Key("A", "a"),
            new Key("B", "b"),
            new Key("C", "c"),
            new Key("D", "d"),
            new Key("E", "e"),
            new Key("F", "f"),
            new Key("G", "g"),
            new Key("H", "h"),
            new Key("I", "i"),
            new Key("J", "j"),
            new Key("K", "k"),
            new Key("L", "l"),
            new Key("M", "m"),
            new Key("N", "n"),
            new Key("O", "o"),
            new Key("P", "p"),
            new Key("Q", "q"),
            new Key("R", "r"),
            new Key("S", "s"),
            new Key("T", "t"),
            new Key("U", "u"),
            new Key("W", "w"),
            new Key("X", "x"),
            new Key("Y", "y"),
            new Key("Z", "z"),
            new Key("Left Arrow", "KEY_LEFT_ARROW"),
            new Key("Right Arrow", "KEY_RIGHT_ARROW"),
            new Key("Down Arrow", "KEY_DOWN_ARROW"),
            new Key("Up Arrow", "KEY_UP_ARROW"),
            new Key("Spacebar", " "),
            new Key("Left Shift", "KEY_LEFT_SHIFT"),
            new Key("Left Ctrl", "KEY_LEFT_CTRL")
        };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
    public class Key
    {
        public string Label { get; }
        public string Value { get; }
        public Key(string label, string value)
        {
            Label = label;
            Value = value;
        }
    }
}
