# DesignPatternImplementations

This project consists of simple practical examples of implementations of various design patterns. The list currently contains:

## Strategy pattern
In the implementation of the strategy pattern, I simulated the handling of various algorithms contained within a classic navigator. Through the graphical interface we can choose which algorithm to use to trace our route (road, by walking or public transport) and the navigator will return the points to be navigated.

## Observer pattern
In the implementation of the observer pattern, I recreated the classic publisher/subscriber case where the moment the publisher changes status, all subscribers must also be notified.

## Decorator pattern
In the implementation of the decorator pattern, I simulated a bartender calculating the cost of his cocktails. So I exploited this pattern to derive the cost of a cocktail from all its basic ingredients.

## Command pattern
In the implementation of the command pattern, I simulated an home remote controller which can be used to control some components of an house, as example lights, windows, doors... Every action is implemented like a standalone command, this permits to decouple the logic between the controller and the actions.

## Adapter pattern
In the implementation of the adapter pattern, I simulated a third-party service returning stock market data in XML format. The client however needs data in JSON format, so it uses the adapter to obtain the data in that format.

## Facade pattern
In the implementation of the facade pattern, I simulated a tedious procedure to turn on a home theatre (turn on the screen, the amplifier, turn off the lights...). Using Facade I then wrapped this procedure so that it could be invoked more easily by a client.

## Template method pattern
In the implementation of the template method pattern, I simulated the preparation of a beverage by defining in an abstract class a sequence of steps to be observed then giving each concrete beverage the possibility of implementing the hook for further operations.

## Iterator pattern
I left the implementation of the iterator pattern generic.
