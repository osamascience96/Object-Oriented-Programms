public class main {

	public static void main(String[] args){
		Food food[] = new Food[2]; // init the array of the food type 
		
		food[0] = new Pizza(550, true, 9, "Cheesy Tikka");
		food[1] = new Lassi(100, false, 10, "Chatti");
		
		for (int i = 0; i < 2; i++) {
			food[i].displayGeneralInformation();
		}
	}
}
