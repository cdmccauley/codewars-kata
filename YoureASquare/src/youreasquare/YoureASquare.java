/*
 * YoureASquare.java
 * 
 * by christopher mccauley
 */

package youreasquare;

public class YoureASquare {
    
    public static boolean isSquare(int n) {
        if (Math.sqrt(n) != (int)Math.sqrt(n)) {
            return false;
        } else {
            return true;
        }
    }

    public static void main(String[] args) {
        System.out.println(isSquare(79119013));
        System.out.println(isSquare(-1));
        System.out.println(isSquare(3));
        System.out.println(isSquare(4));
        System.out.println(isSquare(25));
        System.out.println(isSquare(26));
    }
}