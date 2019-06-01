public class main {

	public static void main(String[] args){
		Food  foodPizza = new Pizza(1000, true, 7, "Cheesy");
		foodPizza.displayGeneralInformation();
		
		Food foodLassi = new Lassi(100, true, 10, "Sweet");
		foodLassi.displayGeneralInformation();
	}
}
