
public class Lassi extends Food{
    private String lassiType;
	
	public Lassi(int price, boolean avaliable, int foodRating, String lassiType) {
		super(price, avaliable, foodRating);
		this.lassiType = lassiType;
	}
	
	public void displayGeneralInformation() {
		System.out.println("The Lassi Type is " + lassiType);
		if (avaliable) {
			System.out.println("The Price is " + price + " and food is available");
			System.out.println("The Product Rating is " + foodRating);
		}else {
			System.out.println("The Price is " + price + " and food is not available");
			System.out.println("The Product Rating is " + foodRating);
		}
	}
}
