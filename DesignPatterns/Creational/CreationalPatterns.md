# Създаващи шаблони за дизайн
## Прототипен шаблон
### Клас диаграма:
![Alt text](../imgs/prototype.png)
### Приложимост:
* Прототипният шаблон се използва, когато искаме клиента да не зависи от това как се създават обектите, как са композирани и как са представени.
* Прототипният шаблон се използва и когато:
  * конкретните инстанции се определят по време на изпълнение на програмата;
  * искаме да избегнем създаването от паралена йерархия от фабрики за създаване на класовете;
  * инстанциите могат да имат само едно от няколко състояния.

### Примерен код:
```cs
public abstract class Prototype
{
    // normal implementation
    public abstract Prototype Clone();
}

public class ConcretePrototype1 : Prototype
{
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone(); // Clones the concrete class.
    }
}

public class ConcretePrototype2 : Prototype
{
    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone(); // Clones the concrete class.
    }
}
```
