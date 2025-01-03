using AbstractFactory_1.IDialog;
using AbstractFactory_1.IToolbar;

namespace AbstractFactory_1.AbstractFactory;

public class LightThemeFactory : IThemeAbstractFactory
{
    public IToolbar.IToolbar GetToolbar()
    {
        IToolbar.IToolbar lightToolbar = new LightToolbar();
        return lightToolbar;
    }

    public IDialog.IDialog GetDialog()
    {
        IDialog.IDialog darkDialog = new DarkDialog();
        return darkDialog;
    }
}