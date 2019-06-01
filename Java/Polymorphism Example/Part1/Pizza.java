
public class Pizza extends Food{
	
	private String pizzaType;
	
	public Pizza(int price, boolean avaliable, int foodRating, String pizzaType) {
		super(price, avaliable, foodRating);
		this.pizzaType = pizzaType;
	}
	
	public void displayGeneralInformation() {
		System.out.println("The Pizza Type is " + pizzaType);
		if (avaliable) {
			System.out.println("The Price is " + price + " and food is available");
			System.out.println("The Product Rating is " + foodRating);
		}else {
			System.out.println("The Price is " + price + " and food is not available");
			System.out.println("The Product Rating is " + foodRating);
		}
	}
}
