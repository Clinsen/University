namespace _9._2 {
    public class TimeMachine {
        private readonly Stack<LifeMemento> _mementos = new Stack<LifeMemento>();

        public void Backup(LifeMemento memento) {
            _mementos.Push(memento);
        }

        public LifeMemento Undo() {
            if (_mementos.Count > 0) {
                return _mementos.Pop();
            }
            else {
                throw new Exception("В стеку більше не залишилося збережених відрізків життя.");
            }
        }
    }
}
