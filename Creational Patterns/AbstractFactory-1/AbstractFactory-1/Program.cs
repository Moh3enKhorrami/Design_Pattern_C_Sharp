
using AbstractFactory_1.AbstractFactory;

namespace AbstractFactory_1
{
    public enum Theme
    {
        Dark = 1,
        Light = 2,
    }
    class Program
    { 
        static void Main(string[] args)
        {
            IThemeAbstractFactory themeAbstractFactory = FactoryProvider.GetFactory(Theme.Dark);
            
            IToolbar.IToolbar toolbar1 = themeAbstractFactory.GetToolbar();
            toolbar1.ShowToolbar();
            
            IDialog.IDialog dialog1 = themeAbstractFactory.GetDialog();
            dialog1.ShowDialog();
            Console.ReadLine();
            
        }
    }
}
