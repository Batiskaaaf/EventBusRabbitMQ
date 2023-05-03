namespace EventBusTestProj.CustomEvents;

public record CustomEventOne : BaseEvent
{
    public CustomEventOne()
    {

    }
    public CustomEventOne(string info)
    {
        this.info = info;
    }
    public string info { get; set; } = "I'm custom event one";
}