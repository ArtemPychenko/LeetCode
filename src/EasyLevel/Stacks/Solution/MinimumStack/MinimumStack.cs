using System.Collections.Generic;

namespace Stacks.Solution.MinimumStack
{
    public class MinimumStack
    {
        private SortedList<int, int> _counter;
        private Stack<int> _minStack;

        /** initialize your data structure here. */
        public MinimumStack()
        {
            _counter = new SortedList<int, int>();
            _minStack = new Stack<int>();
        }

        public void Push(int x)
        {
            if (_counter.ContainsKey(x))
            {
                _counter[x] += 1;
            }
            else
            {
                _counter.Add(x, 1);
            }

            _minStack.Push(x);
        }

        public void Pop()
        {
            if (_counter[_minStack.Peek()] > 1)
            {
                _counter[_minStack.Peek()] -= 1;
            }
            else
            {
                _counter.Remove(_minStack.Peek());
            }

            _minStack.Pop();
        }

        public int Top()
        {
            return _minStack.Peek();
        }

        public int GetMin()
        {
            return _counter.Keys[0];
        }
    }
}
