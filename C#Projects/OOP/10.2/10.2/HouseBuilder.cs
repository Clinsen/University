namespace _10._2 {
    abstract class HouseBuilder {
        public void BuildHouse() {
            LayFoundation();
            BuildWalls();
            AddRoof();
            AddExtraFeatures();
            PaintHouse();
            Console.WriteLine("Будівництво завершено.");
        }

        protected void LayFoundation() {
            Console.WriteLine("Кладемо фундамент.");
        }

        protected void BuildWalls() {
            Console.WriteLine("Будуємо стіни.");
        }

        protected void AddRoof() {
            Console.WriteLine("Додаємо дах.");
        }

        protected void PaintHouse() {
            Console.WriteLine("Фарбуємо будинок.");
        }

        protected abstract void AddExtraFeatures();
    }
}
