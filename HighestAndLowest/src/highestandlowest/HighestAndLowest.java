/*
 * HighestAndLowest.java
 * 
 * by christopher mccauley
 */

package highestandlowest;

import java.util.List;
import java.util.ArrayList;
import java.util.Collections;

public class HighestAndLowest {
    
    public static String HighAndLow(String numbers) {
        List<Integer> list  = new ArrayList<Integer>();
        String[] values;
        
        values = new String[numbers.length()];
        values = numbers.split(" ");
        
        for (int i = 0; i < values.length; i++) {
            list.add(Integer.parseInt(values[i]));
        }
        
        return Collections.max(list).toString().concat(" ".concat(Collections.min(list).toString()));
    }

    public static void main(String[] args) {
        String testString1 = "1 2 3 4 5";
        String testString2 = "1 2 -3 4 5";
        String testString3 = "1 9 3 4 -5";
        
        System.out.println(HighAndLow(testString1));
        System.out.println(HighAndLow(testString2));
        System.out.println(HighAndLow(testString3));
    }
}