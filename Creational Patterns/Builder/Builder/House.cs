namespace Builder;

public class House
{
    private string foundation;
    private string structure;
    private bool painted;
    private bool furnished;
    private string roof;

    public string Foundation
    {
        set
        {
            foundation = value;
        }
    }

    public string Structure
    {
        set
        {
            structure = value;
        }
    }

    public string Roof
    {
        set
        {
            roof = value;
        }
    }

    public bool Painted
    {
        set
        {
            painted = value;
        }
    }

    public bool Furnished
    {
        set
        {
            furnished = value;
        }
    }

    public override string ToString()
    {
        return "Foundation " + foundation + "Structure " + structure + "Roof "
               + roof + "House is: " + painted + "House is: " + furnished;
    }
}