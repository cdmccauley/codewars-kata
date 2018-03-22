public class Main {

    public static int lostSheeps(int[] fridayNightCounting, int[] saturdayNightCounting, int sheepsTotal) {
        int count = 0;

        for (int sheep : fridayNightCounting) {
            count += sheep;
        }
        for (int sheep : saturdayNightCounting) {
            count += sheep;
        }

        return sheepsTotal - count;
    }

    public static void main(String[] args) {
        System.out.println(lostSheeps(new int[] {1,2}, new int[] {3,4}, 15));
        System.out.println(lostSheeps(new int[] {3,1,2}, new int[] {4,5}, 21));
    }
}
