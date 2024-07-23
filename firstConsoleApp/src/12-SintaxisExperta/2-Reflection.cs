namespace SintaxisExperta;

class Reflection
{
    public void ReadAttributes(Type attribute)
    {
        Attribute[] attributes = Attribute.GetCustomAttributes(attribute);

        foreach (Attribute attr in attributes)
        {
            if (attr is AttributeWithParamsAttribute attributeWithParamsAttribute)
            {
                Console.WriteLine($"{attributeWithParamsAttribute.GetTittle()}  :  {attributeWithParamsAttribute.Description}");
            }
        }
    }
}
