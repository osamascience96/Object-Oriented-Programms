
public class Food {
	protected int price;
	protected boolean avaliable;
	protected int foodRating;
	
	public Food(int price, boolean avaliable, int foodRating) {
		this.price = price;
		this.avaliable = avaliable;
		this.foodRating = foodRating;
	}
	
	public void displayGeneralInformation() {
		if (avaliable) {
			System.out.println("The Price is " + price + " and food is available");
			System.out.println("The Product Rating is " + foodRating);
		}else {
			System.out.println("The Price is " + price + " and food is not available");
			System.out.println("The Product Rating is " + foodRating);
		}
	}
}