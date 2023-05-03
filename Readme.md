# Getting Started with EventBusRabbitMq

This project was borrowed from [MSDN eShopOnContainers](https://github.com/dotnet-architecture/eShopOnContainers).

## For EventBus to run

You need either: 

1. Run RabbitMq on your local machine
    [windows](https://community.chocolatey.org/packages/rabbitmq)

2. Run RabbitMq in a [docker](https://hub.docker.com/_/rabbitmq)

## Getting started

1. Add references to the EventBus and EventBusRabbitMQ libraries.

1. Register EventBusRabbitMq (see EventBusTest Program.cs line 39)
    1.1 HostName for ConnectionFactory in our case is localhost
        if running in Kubernetes or Docker, change it
    1.2 ClientName for EventBusRabbitMQ the name of your service
        ex. (PingService, Aggregator, Authorization)

## Publishing an event

1. Create a record "CustomEvent" (not a class) inherited from "BaseEvent" (see  EventBusTest Evets)
    1.1 The "CustomEvent" record is stored in the folder of your service, there is no need to change the BuildingBlocks folder

2. Using DI, get the IEventBus service (see EventBusTest SendController.cs line 19)

3. Publish your event (see EventBusTest SendController.cs line 32)

All subscribed services received our event

## Subscribing on event

1. Create "CustomEventHandler<T>" and inherit from IIntegrationEventHandler<T>
    where T is the event we want to listen to. Implement Handle as needed. (see EventBusTest CustomEventsHandler)

2. Register "CustomEventHandler" in DI (see EventBusTest Program.cs line 63)

3. Configure subscriptions (see EventBusTest Program.cs line 71)
    3.1 The Subscribe<T, TH> method where T is the event we want to listen to, and Th is the handler that will handle it.

Now we are subscribed to the events

## Learn More

You can learn more about RabbitMQ on [RabbitMQ official tutorials](https://www.rabbitmq.com/getstarted.html).
