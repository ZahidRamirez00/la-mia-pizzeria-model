using La_Mia_Pizzeria_1.Models;

namespace La_Mia_Pizzeria_1.Utils
{
    public static class PizzeData
    {
        private static List<Pizza> pizze;
        
        public static List<Pizza> GetPizze()
        {
            List<string> nomi = new List<string> { "Marinara", "Margherita", "Pugliese", "Napoli", "Funghi", "Prosciutto cotto", "Carciofi", "Romana", "Zola", "alla Scamorza", "Prosciutto e funghi" };
            List<string> descrizioni = new List<string> { "(pomodoro, origano, aglio ed olio)", "(pomodoroe mozzarella)", "(pomodoro, mozzarella e cipolla)", "(pomodoro, mozzarella e acciughe)", "(pomodoro, mozzarella e funghi)", "(pomodoro, mozzarella e prosciutto cotto)", "(pomodoro, mozzarella e carciofi)", "(pomodoro, mozzarella, acciughe, capperi, olive e origano)", "(pomodoro, mozzarella e zola)", "(pomodoro e scamorza)", "(pomodoro, mozzarella, prosciutto cotto e funghi)" };
            List<string> immagini = new List<string> { "~/img/pizza_0.jpg", "~/img/pizza_1.jpg", "~/img/pizza_2.jpg", "~/img/pizza_3.jpg", "~/img/pizza_4.jpg", "~/img/pizza_5.jpg", "~/img/pizza_6.jpg", "~/img/pizza_7.jpg", "~/img/pizza_8.jpg", "~/img/pizza_9.jpg", "~/img/pizza_10.jpg" };
            List<string> prezzi = new List<string> { "8,50 €", "4,50 €", "7,50 €", "6,50 €", "6,50 €", "5,50 €", "6,50 €", "6,50 €", "5,50 €", "5,50 €", "7,50 €" };
            if(pizze != null) return pizze;

            pizze = new List<Pizza>();

            for(int i = 0; i <= nomi.Count; i++)
            {
                Pizza pizza = new Pizza(i, nomi[i], descrizioni[i], immagini[i], prezzi[i]);
                pizze.Add(pizza);
            }
            return pizze;
        }
    }
}
