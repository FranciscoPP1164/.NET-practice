namespace SintaxisAvanzada;

//Una clase que extiende de EventArgs se suele usar como argumento enviado del emisor a los receptores sin embargo
//No ofrece ventajas y por el contrario tiene limitantes en cuanto a diseño
public class EventLaunchedArgs : EventArgs
{
    public bool CancelRequested { get; set; }
}

//Los eventos permiten programar de manera reactiva, es decir que permite que n numero de objetos receptores
//Se puedan suscribir a un evento que un objeto emisor pueda activar en cualquier momento
//Todos los objetos receptores se enteraran de cuando el objeto emisor realizar x accion
class Events
{
    //La palabra reservada event permite declarar una propiedad como evento
    public event EventHandler<EventLaunchedArgs>? Progress;

    public void StartProcess()
    {
        Console.WriteLine("El proceso ha iniciado");
        EventLaunchedArgs args = new();
        //Los eventos se disparan con el metodo Invoke
        Progress?.Invoke(this, args);
        if (args.CancelRequested)
        {
            Console.WriteLine("El proceso se ha cancelado");
            return;
        }
        Console.WriteLine("El proceso se ha terminado");
    }
}

class Suscriptor
{
    private readonly Events Events;

    public Suscriptor(Events events)
    {
        Events = events;
        SubscribeToEvents();
    }

    public void OnProgress(object? sender, EventLaunchedArgs args)
    {
        Console.WriteLine("El proceso se esta ejecutando");
        string willCancelRequest = Console.ReadLine();
        if (willCancelRequest.ToLower() == "y")
        {
            args.CancelRequested = true;
        }
    }

    //Para suscribirse a un evento se tiene que utilizar el operador += con un metodo o delegado que cumpla
    //Con la firma de un escuchador de eventos
    private void SubscribeToEvents()
    {
        Events.Progress += OnProgress;
    }

    //Con el operador -= se desuscribe a el evento
    public void UnsubscribeToEvents()
    {
        Events.Progress -= OnProgress;
    }
}
