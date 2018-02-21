/*
 * ShortestWord.java
 * 
 * by christopher mccauley
 */

package shortestword;

public class ShortestWord {
    
    public static int findShort(String s) {
        String[] wordList = s.split(" ");
        String shortestString = wordList[0];
        
        for (int i = 0; i < wordList.length; i++) {
            if (shortestString.length() > wordList[i].length()) {
                shortestString = wordList[i];
            }
        }
        return shortestString.length();
    }

    public static void main(String[] args) {
        String testString1 = "bitcoin take over the world maybe who knows perhaps";
        String testString2 = "turns out random test cases are easier than writing out basic ones a";
        
        System.out.println(findShort(testString1));
        System.out.println(findShort(testString2));
        
    }
}