public class Birthday {
	private int date;
	private int month;
	private int year;
	
	public Birthday(int date, int month, int year) {
		this.date = date;
		this.month = month;
		this.year = year;
	}
	
	public String GetBirthInformation() {
		return date + "/" + month + "/" + year;
	}
}
