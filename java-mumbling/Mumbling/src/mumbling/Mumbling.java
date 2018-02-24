/*
 * Mumbling.java
 * 
 * by christopher mccauley
 */

package mumbling;

public class Mumbling {
    
    public static String accum(String s) {
        String accumString = new String();
        
        for (int i = 0; i < s.length(); i++) {
            if (i > 0) {
                accumString += '-';
            }
            for (int j = 0; j < i + 1; j++) {
                if (j == 0) {
                    accumString += s.toUpperCase().charAt(i);
                } else {
                    accumString += s.toLowerCase().charAt(i);
                }
            }
        }
        return accumString;
    }

    public static void main(String[] args) {
        System.out.println(accum("abcd"));
        System.out.println(accum("RqaEzty"));
        System.out.println(accum("cwAt"));
    }
}