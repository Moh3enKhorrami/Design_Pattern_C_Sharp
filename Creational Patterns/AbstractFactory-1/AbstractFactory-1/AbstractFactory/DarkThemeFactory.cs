using AbstractFactory_1.IDialog;
using AbstractFactory_1.IToolbar;

namespace AbstractFactory_1.AbstractFactory;

public class DarkThemeFactory : IThemeAbstractFactory
{
    public IToolbar.IToolbar GetToolbar()
    {
        IToolbar.IToolbar darkToolbar = new DarkToolbar();
        return darkToolbar;
    }

    public IDialog.IDialog GetDialog()
    {
        IDialog.IDialog darkDialog = new DarkDialog();
        return darkDialog;
    }
}