namespace SintaxisAvanzada;

class Discards
{
    public void TupleObjectDeconstruction()
    {
        //El operador discard _ permite omitir una variable la cual tubiera que ser asignada en una expresion
        //como por ejemplo una deconstruccion o un metodo que devuelva una tupla, de esta forma no se crea una
        //variable en memoria y se declara de forma explicita que ese valor es irrelevante para
        //la operacion que se este llevando a cabo en ese momento
        var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

        Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");

        (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            double area = 0;

            if (name == "New York City")
            {
                area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }

            return ("", 0, 0, 0, 0, 0);
        }

        var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

        var (fName, _, city, _) = p;
        Console.WriteLine($"Hello {fName} of {city}!");
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Person(string fname, string mname, string lname, string cityName, string stateName)
        {
            FirstName = fname;
            MiddleName = mname;
            LastName = lname;
            City = cityName;
            State = stateName;
        }

        //El metodo Deconstruct de una clase se usa para definir el comportamiento que tendra un objeto de un tipo
        //cuando este sea usado en una expresion de deconstruccion
        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string lname, out string city, out string state)
        {
            fname = FirstName;
            lname = LastName;
            city = City;
            state = State;
        }
    }
}
