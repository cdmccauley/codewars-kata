// Thanks to https://stackoverflow.com/questions/4201860/how-to-find-gcd-lcm-on-a-set-of-numbers
import java.util.Arrays;

public class Main {

    private static long gcd(long x, long y) {
        return (y == 0) ? x : gcd(y, x % y);
    }

    public static long lcm(long... numbers) {
        return Arrays.stream(numbers).reduce(1, (x, y) -> x * (y / gcd(x, y)));
    }

    public static String convertFrac(long[][] lst) {
        long[] denominators = new long[lst.length];
        long[] numerators = new long[lst.length];
        long commonDenominator, commonNumerator;
        StringBuilder converted = new StringBuilder();

        for (int i = 0; i < lst.length; i++) {
            numerators[i] = lst[i][0];
            denominators[i] = lst[i][1];
        }

        commonNumerator = lcm(numerators);
        commonDenominator = lcm(denominators);

        if (commonDenominator == 1) {
            for (int i = 0; i < lst.length; i++) {
                converted.append("(" + lst[i][0] + "," + lst[i][1] + ")");
            }
        } else if (commonNumerator == 1) {
            for (int i = 0; i < lst.length; i++) {
                converted.append("(" + (commonDenominator / denominators[i]) + "," + (commonDenominator) + ")");
            }
        } else {
            for (int i = 0; i < lst.length; i++) {
                converted.append("(" + ((commonDenominator / denominators[i]) * lst[i][0]) + "," + (commonDenominator) + ")");
            }
        }
        return converted.toString();
    }

    public static void main(String[] args) {
        System.out.println(convertFrac(new long[][] { {1, 2}, {1, 3}, {1, 4} }));
        System.out.println(convertFrac(new long[][] { {69, 130}, {87, 1310}, {3, 4} })); // 18078, 2262, 25545
    }
}
