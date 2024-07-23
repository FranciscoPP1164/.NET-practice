using System.Runtime.InteropServices;

namespace SintaxisExperta;

//Los atributes permiten insertar metadata al codigo, es como una forma de dar informacion al codigo
//sobre el codigo en si.
[Serializable]
class Attributes
{ }

/*
Para crear un attribute se debe crear una clase que extienda la clase Attribute, los Attributes
pueden tener Attributes
Los parametros definidos en el constructor del Attribute seran tomados como attributes a
*/
[AttributeUsage(AttributeTargets.All)]
class AttributeWithParamsAttribute(string tittle) : Attribute
{
    private readonly string Tittle = tittle;
    public string Description = "";

    public string GetTittle()
    {
        return Tittle;
    }
}

[AttributeUsage(AttributeTargets.Class)]
class AttributeOnlyForClassesAttribute : Attribute
{

}

[AttributeOnlyForClasses, AttributeWithParams("Casita", Description = "Una casa muy bonita")]
class AnClass
{
    [DllImport("user32.dll")]
    public extern static void AnMethod();

    public void AnotherMethod([In, Out] int number)
    {

    }
}

// [AttributeOnlyForClasses]
struct AnStruct
{

}
