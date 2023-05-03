namespace EventBusTestProj.CustomEventsHandlers;

public class EventTwoHandler : IBaseEventHandler<CustomEventTwo>
{
    public async Task Handle(CustomEventTwo baseEvent)
    {
        System.Console.WriteLine($" I'm EventTwoHandler, received: {JsonSerializer.Serialize(baseEvent)}");
    }
}