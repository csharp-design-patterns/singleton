# Design Patterns: Singleton

This is a creation pattern, that guarantees only one object instance while the life cycle project.

But why and when can I use it? For example, when you use MongoDB in your application. The MongoDB do not use the connection pool, like relational databases, so is best for it to keep the connection always open and only one for all the project. In this case, we can use the Singleton pattern to involve the class that responsible to open and return the connection for us.


## Characteristics 📚

* Has only one object instance for the project
* In many cases, it consider an anti-pattern

## Hands-on 🤓

For the class that we want to involve with Singleton Pattern, we just include a private constructor and a method that return the existing instance:

```rb
public class Repository
{
	private static IContext _context;

    private Repository() { }

    public static IContext GetInstance()
    {
        if (_context is null)
        {
            _context = new Context.Context();
            _context.OpenConnection();
        }

    	return _context;
    }
}

```

The private constructor prevents that we build the class in another location, out of it. And the method [*GetInstance*] guarantee the return the same instance was created, every time.

And for test our class:

```rb
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Singleton Sample...");

        var repository1 = Repository.Repository.GetInstance();
        var repository2 = Repository.Repository.GetInstance();

        if (repository1 is not null && repository1.Equals(repository2))
        	Console.WriteLine("Singleton works.");
        else
        	throw new InvalidOperationException("Singleton failed.");
    }
}
```
The two repositories that were "created", should have the same instance.


## Conclusion ✔

* It's too easy to implement.
* The same class supports a multithread environment incorrectly. Because may be create many different instance

---

### References 📜
* [Refactoring Guru - Design Pattern Singleton](https://refactoring.guru/design-patterns/singleton/csharp/example)