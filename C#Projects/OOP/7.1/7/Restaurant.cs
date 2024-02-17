using System.Collections;

namespace _7 {
    public class Restaurant {
        public ArrayList ordersList;
        

        public Restaurant() {
            ordersList = new ArrayList();
        }

        public override string ToString() {
            if (ordersList.Count == 0) {
                return "Замовлень немає.";
            }
            else {
                string showOrders = "Ваші замовлення: ";
                for (int i = 0; i < ordersList.Count; i++) {
                    showOrders += $"\n{i + 1}. {ordersList[i]}";
                }
                return showOrders;
            }
        }
    }
}
