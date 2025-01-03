using AbstractFactory_1.AbstractFactory;

namespace AbstractFactory_1;

public class FactoryProvider
{
    public static IThemeAbstractFactory GetFactory(Theme theme)
    {
        IThemeAbstractFactory themeAbstractFactory = null;
        switch (theme)
        {
            case    Theme.Light:
                themeAbstractFactory = new LightThemeFactory();
                break;
            case    Theme.Dark:
                themeAbstractFactory = new DarkThemeFactory();
                break;
        }
        return themeAbstractFactory;
    }
}