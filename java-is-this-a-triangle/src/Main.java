public class Main {

    public static boolean isTriangle(int a, int b, int c){
        return (a + b > c && a + c > b && b + c > a); // triangle inequality
    }

    public static void main(String[] args) {
        System.out.println(isTriangle(1,2,2)); // true
        System.out.println(isTriangle(7,2,2)) ; // false
    }
}
