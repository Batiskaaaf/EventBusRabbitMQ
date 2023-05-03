namespace EventBusTestProj.CustomEventsHandlers;

public class EventOneHandler : IBaseEventHandler<CustomEventOne>
{
    public async Task Handle(CustomEventOne baseEvent)
    {
        System.Console.WriteLine($" I'm EventOneHandler, received: {JsonSerializer.Serialize(baseEvent)}");
    }
}