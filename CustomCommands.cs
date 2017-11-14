using System.Windows.Input;

namespace ResorcesDemo
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand
        (
                text: "Выход",
                name: "Exit",
                ownerType: typeof(CustomCommands),
                inputGestures: new InputGestureCollection()
                {
                    new KeyGesture(Key.F3, ModifierKeys.Alt)
                }
        );

        //Define more commands here, just like the one above
    }
}
