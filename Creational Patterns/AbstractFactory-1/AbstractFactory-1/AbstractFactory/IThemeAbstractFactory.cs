namespace AbstractFactory_1.AbstractFactory;

public interface IThemeAbstractFactory
{
    IToolbar.IToolbar GetToolbar();
    IDialog.IDialog GetDialog();
    
}