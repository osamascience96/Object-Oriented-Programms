
public class Person {
	private String name;
	private Birthday birthInfo;
	private boolean martialStatus;
	
	
	public Person(String name, Birthday birthInfo, boolean martialStatus) {
		this.name = name;
		this.birthInfo = birthInfo;
		this.martialStatus = martialStatus;
	}
	
	public void DisplayInfo() {
		System.out.println("My name is " + this.name);
		System.out.println("My Date of Birth is " + this.birthInfo.GetBirthInformation());
		if (martialStatus) {
			System.out.println("I am Married");
		}else {
			System.out.println("I am not Married");
		}
	}
}
