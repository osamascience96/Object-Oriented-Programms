
abstract public class Food {
	protected int price;
	protected boolean avaliable;
	protected int foodRating;
	
	public Food(int price, boolean avaliable, int foodRating) {
		this.price = price;
		this.avaliable = avaliable;
		this.foodRating = foodRating;
	}
	
	// this class can have an abstract method
	public abstract void displayGeneralInformation();
	
	// this class also have a non abstract method
	public static void Comment() {
		System.out.println("This Food is Great!!!");
	}
}