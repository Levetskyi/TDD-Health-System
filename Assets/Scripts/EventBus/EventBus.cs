using System.Collections.Generic;

public static class EventBus<T> where T : IEvent
{
	static readonly HashSet<IEventBinding<T>> bindings = new();

	public static void Register(EventBinding<T> binding) => bindings.Add(binding);
    public static void Deregister(EventBinding<T> binding) => bindings.Remove(binding);

	public static void Raise(T @event)
	{
		foreach (var binding in bindings)
		{
			binding.OnEvent.Invoke(@event);
			binding.OnEventNoArgs.Invoke();
		}
	}

	private static void Clear()
	{
		bindings.Clear();
	}
}