public class Main {
    public static int findLongest(int[] numbers) {
        int largestLength = 0;
        int largestValue = numbers[0];

        for (Integer i : numbers ) {
            Integer num = Math.abs(i);
            if (num.toString().length() > largestLength) {
                largestLength = num.toString().length();
                largestValue = i;
            }
        }

        return largestValue;
    }

    public static void main(String[] args) {
        System.out.println(findLongest(new int[]{1, 10, 100}));
        System.out.println(findLongest(new int[]{9000, 8, 800}));
        System.out.println(findLongest(new int[]{8, 900, 500}));
        System.out.println(findLongest(new int[]{3, 40000, 100}));
        System.out.println(findLongest(new int[]{1, 200, 100000}));
        System.out.println(findLongest(new int[]{-10, 1, 0, 1, 10}));
    }
}
