namespace EventBus.Abstractions;

public interface IDynamicBaseEventHandler
{
    Task Handle(dynamic eventData);
}
