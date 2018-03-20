public class Main {
    public static int mxdiflg(String[] a1, String[] a2) {
        String a1Smallest, a1Largest, a2Smallest, a2Largest;
        
        if (a1.length == 0 || a2.length == 0) {
            return -1;
        } else {
            a1Smallest = a1[0];
            a1Largest = a1[0];
            a2Smallest = a2[0];
            a2Largest = a2[0];
            for (String a1String : a1) {
                if (a1String.length() > a1Largest.length()) {
                    a1Largest = a1String;
                }
                if (a1String.length() < a1Smallest.length()) {
                    a1Smallest = a1String;
                }
            }
            for (String a2String : a2) {
                if (a2String.length() > a2Largest.length()) {
                    a2Largest = a2String;
                }
                if (a2String.length() < a2Smallest.length()) {
                    a2Smallest = a2String;
                }
            }
            if (a1Largest.length() - a2Smallest.length() > a2Largest.length() - a1Smallest.length()) {
                return a1Largest.length() - a2Smallest.length();
            } else {
                return a2Largest.length() - a1Smallest.length();
            }
        }
    }

    public static void main(String[] args) {
        String[] s1 = new String[]{"hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"};
        String[] s2 = new String[]{"cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"};

        System.out.println(mxdiflg(s1, s2));
    }
}
