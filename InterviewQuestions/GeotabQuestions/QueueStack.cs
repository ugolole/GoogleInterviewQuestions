namespace InterviewQuestions.GeotabQuestions;

/// <summary>
/// An implementation of a queue using 2 stacks
/// </summary>
public class QueueStack<T>  where T: class
{
    private readonly Stack<T> _first;

    private readonly Stack<T> _second;

    public QueueStack()
    {
        _first = new Stack<T>();
        _second = new Stack<T>();
    }

    /// <summary>
    /// Add an item to the queue.
    /// </summary>
    /// <param name="t">The item to be add to the queue</param>
    public void Enqueue(T t)
    {
        _first.Push(t);
    }

    /// <summary>
    /// Returns first item in the queue.
    /// </summary>
    /// <returns>The item to be returned from the queue.</returns>
    public T Dequeue()
    {
        if (_second.Count == 0)
        {
            while (_first.Count != 0)
            {
                _second.Push(_first.Pop());
            }
        }
        return _second.Pop();
    }
}