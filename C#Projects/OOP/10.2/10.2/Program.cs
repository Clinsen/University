using System.Text;

namespace _10._2 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Будуємо будинок з мансардою:");
            HouseBuilder houseWithAttic = new AtticBuilder();
            houseWithAttic.BuildHouse();

            Console.WriteLine("\nБудуємо будинок з балконом:");
            HouseBuilder houseWithBalcony = new BalconyBuilder();
            houseWithBalcony.BuildHouse();

            Console.WriteLine("\nБудуємо будинок з гаражем:");
            HouseBuilder houseWithGarage = new GarageBuilder();
            houseWithGarage.BuildHouse();

            Console.WriteLine("\nБудуємо будинок з верандою:");
            HouseBuilder houseWithVeranda = new VerandaBuilder();
            houseWithVeranda.BuildHouse();
        }
    }
}
