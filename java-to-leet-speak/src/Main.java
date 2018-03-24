import java.util.Hashtable;

public class Main {

    static String toLeetSpeak(final String speak) {
        // declarations
        Hashtable<Character, Character> leetCipher = new Hashtable<>(26);
        char[] leetSpeak = {'@', '8', '(', 'D', '3', 'F', '6', '#', '!', 'J', 'K', '1',
                'M', 'N', '0', 'P', 'Q', 'R', '$', '7', 'U', 'V', 'W', 'X', 'Y', '2'};
        StringBuilder leetTranslation = new StringBuilder();
        char[] input = speak.toCharArray();

        // load hashtable (65-90 is unicode A-Z)
        for (int i = 0; i <= 25; i++) {
            leetCipher.put((char)(i + 65), leetSpeak[i]);
        }

        // translate
        for (char letter : input) {
            if (leetCipher.containsKey(letter)) {
                leetTranslation.append(leetCipher.get(letter));
            } else {
                leetTranslation.append(letter);
            }
        }

        return leetTranslation.toString();
    }

    public static void main(String[] args) {
        System.out.println(toLeetSpeak("LEET")); // 1337
        System.out.println(toLeetSpeak("CODEWARS")); // (0D3W@R$
        System.out.println(toLeetSpeak("HELLO WORLD")); // #3110 W0R1D
        System.out.println(toLeetSpeak("LOREM IPSUM DOLOR SIT AMET")); // 10R3M !P$UM D010R $!7 @M37
        System.out.println(toLeetSpeak("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG")); // 7#3 QU!(K 8R0WN F0X JUMP$ 0V3R 7#3 1@2Y D06
    }
}
