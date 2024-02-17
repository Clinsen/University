namespace _9._2 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            TimeMachine timeMachine = new TimeMachine();
            LifeCycle life = new LifeCycle("Дитинство");


            var childhoodMemento = life.CurrentState;
            timeMachine.Backup(new LifeMemento(childhoodMemento));
            Console.WriteLine("Початковий стан життя: " + life.ToString());


            life.SetLifeState("Підліткові роки");
            var teenagehoodMemento = life.CurrentState;
            timeMachine.Backup(new LifeMemento(teenagehoodMemento));
            Console.WriteLine("Наступний життєвий цикл: " + life.ToString());


            life.SetLifeState("Дорослі роки");
            var adulthoodMemento = life.CurrentState;
            timeMachine.Backup(new LifeMemento(adulthoodMemento));
            Console.WriteLine("Наступний життєвий цикл: " + life.ToString());

            Console.WriteLine("Використання машини часу...");
            timeMachine.Undo();
            timeMachine.Undo();

            life.SetLifeState(timeMachine.Undo().LifeState);
            Console.WriteLine("Поточний життєвий цикл: " + life.ToString());
        }
    }
}
