using System.Diagnostics;

namespace ProgramacionAsincrona;

internal class Bacon { }
internal class Coffee { }
internal class Egg { }
internal class Juice { }
internal class Toast { }

//La sintaxis de programacion asincrona de c# permite escribir codigo que se lea de manera secuencial
//pero que se ejecuta de manera asincrona, es muy similar a la asincronia de promesas en JS
//Esto mejora la performance y escalabilidad de las aplicaciones
class ConceptoGeneral
{
    //Para declarar que un metodo se ejecutara de forma asincrona hay que usar la palabra reservada async
    //esto hace que el compilador internamente la procese de una forma diferente y asigne la ejecucion de
    //este metodo en un hilo diferente del principal, haciendo que hambos se ejecuten en paralelo.
    //Con esto logramos que la ejecucion del metodo asincrono no bloquee la ejecucion del hilo principal
    //Y este pueda ejecutar otras tareas al mismo tiempo
    public async Task MakeBreakfast()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Coffee cup = PourCoffee();
        Console.WriteLine("Cafe listo");

        //Un metodo asincrono siempre devolvera un objeto de tipo Task o Task<TResult> donde TResult es
        //el tipo devuelto por la funcion con la instruccion return.
        //Cuando se ejecuta una funcion asincrona se crea una tarea que ejecuta de manera paralela con las
        //demas tareas, por lo tanto los metodos FryEggsAsync(), FryBaconAsync() y ToastBreadAsync() a pesar
        //de que se lean de manera secuencial en el codigo, estos seran ejecutados en paralelo, es decir
        //que los tres se empezaran a ejecutar al mismo tiempo.
        //Importante recordar que no se estan creando hilos ni se esta haciendo uso del patron multithreading
        Task<Egg> eggsTask = FryEggsAsync(2);
        Task<Bacon> baconTask = FryBaconAsync(3);
        Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);

        /**
        Todo metodo asincrono tiene que hacer uso por lo menos una vez en su declaracion la palabra reservada
        await, esta palabra indica que en este punto se tendra que esperar a que una tarea que se esta ejecutando
        de forma asincrona sea terminada
        **/
        // Toast toast = await toastTask;
        // Console.WriteLine("Tostada lista");

        /**
        La palabra reservada await indica que se tiene que parar la ejecucion del hilo del metodo
        en ese punto y esperar a que se termine la tarea que se indique, por esto a pesar de que la tarea
        baconTask termina antes que toastTask y eggsTask, esta no se le permite concluir como terminada
        antes que las otras que se toman un segundo mas.
        **/
        // Egg eggs = await eggsTask;
        // Console.WriteLine("Huevos listos");

        // Bacon bacon = await baconTask;
        // Console.WriteLine("Tocino listo");

        List<Task> breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
        while (breakfastTasks.Count > 0)
        {
            /*
            Con El metodo WhenAny de la clase Task podemos detectar cuando una de las tareas de una
            Lista de tareas ha sido completada y asi podemos procesar esa tarea terminada
            */
            Task finishedTask = await Task.WhenAny(breakfastTasks);
            if (finishedTask == eggsTask)
            {
                Console.WriteLine("Huevos listos");
            }
            else if (finishedTask == baconTask)
            {
                Console.WriteLine("Tocino listo");
            }
            else if (finishedTask == toastTask)
            {
                Console.WriteLine("Tostada lista");
            }
            await finishedTask;
            breakfastTasks.Remove(finishedTask);
        }

        Juice oj = PourOrangeJuice();
        Console.WriteLine("Jugo de naranja listo");

        Console.WriteLine("DESAYUNO LISTO!");

        stopwatch.Stop();
        string time = stopwatch.Elapsed.ToString("mm\\:ss\\.ff");

        Console.WriteLine(time);
    }

    private static Juice PourOrangeJuice()
    {
        Console.WriteLine("Exprimiendo jugo de naranja");
        return new Juice();
    }

    private static void ApplyJam(Toast toast) =>
        Console.WriteLine("Poniendo mermelada en la tostada");

    private static void ApplyButter(Toast toast) =>
        Console.WriteLine("Poniendo mantequilla en la tostada");

    private static Toast ToastBread(int slices)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Poniendo una rebanada de pan en la tostadora");
        }
        Console.WriteLine("Tostando...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Remover tostada de la tostadora");

        return new Toast();
    }

    /*
    Los metodos asincronos por convencion tienen siempre en su nombre el sufijo Async
    */
    private static async Task<Toast> ToastBreadAsync(int slices)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Poniendo una rebanada de pan en la tostadora");
        }
        Console.WriteLine("Tostando...");
        //Proceso bloqueante que requiere de una espara para poder proseguir con la funcionalidad normal
        //del metodo
        await Task.Delay(3000);
        Console.WriteLine("Remover tostada de la tostadora");

        return new Toast();
    }

    static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
    {
        var toast = await ToastBreadAsync(number);
        ApplyButter(toast);
        ApplyJam(toast);

        return toast;
    }

    private static Bacon FryBacon(int slices)
    {
        Console.WriteLine($"Poniendo {slices} revanadas de tocino en la cacerola");
        Console.WriteLine("Cocinando primer lado del tocino...");
        Task.Delay(3000).Wait();
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("volteando una rebanada de tocino");
        }
        Console.WriteLine("Cocinando el segundo lado del tocino...");
        Task.Delay(3000).Wait();
        Console.WriteLine("Poniendo tocino en el plato");

        return new Bacon();
    }

    private static async Task<Bacon> FryBaconAsync(int slices)
    {
        Console.WriteLine($"Poniendo {slices} revanadas de tocino en la cacerola");
        Console.WriteLine("Cocinando primer lado del tocino...");
        await Task.Delay(3000);
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("volteando una rebanada de tocino");
        }
        Console.WriteLine("Cocinando el segundo lado del tocino...");
        await Task.Delay(2000);
        Console.WriteLine("Poniendo tocino en el plato");

        return new Bacon();
    }

    private static Egg FryEggs(int howMany)
    {
        Console.WriteLine("Calentar la sarten para los huevos...");
        Task.Delay(3000).Wait();
        Console.WriteLine($"rompiendo {howMany} huevos");
        Console.WriteLine("Cocinando huevos ...");
        Task.Delay(3000).Wait();
        Console.WriteLine("poniendo huevos en el plato");

        return new Egg();
    }

    private static async Task<Egg> FryEggsAsync(int howMany)
    {
        Console.WriteLine("Calentar la sarten para los huevos...");
        await Task.Delay(3000);
        Console.WriteLine($"rompiendo {howMany} huevos");
        Console.WriteLine("Cocinando huevos ...");
        await Task.Delay(3000);
        Console.WriteLine("poniendo huevos en el plato");

        return new Egg();
    }

    private static Coffee PourCoffee()
    {
        Console.WriteLine("Sirvendo cafe");
        return new Coffee();
    }
}
