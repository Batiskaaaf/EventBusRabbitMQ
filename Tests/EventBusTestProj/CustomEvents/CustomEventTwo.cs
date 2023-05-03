namespace EventBusTestProj.CustomEvents;

public record CustomEventTwo : BaseEvent
{
    public CustomEventTwo()
    {

    }
    public CustomEventTwo(string info)
    {
        this.info = info;
    }
    public string info { get; set; } = "I'm custom event two";
}