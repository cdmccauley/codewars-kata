public class Main {

    public static int sumOfAngles(int n) {
        return 180 * (n - 2);
    }

    public static void main(String[] args) {
	    System.out.println(sumOfAngles(3));
        System.out.println(sumOfAngles(4));
    }
}
