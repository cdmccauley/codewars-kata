import java.util.ArrayList;
import java.util.Arrays;
import java.util.Stack;

public class Main {

    public static int[] DataReverse(int[] data) {
        // declarations
        Stack<int[]> byteSets = new Stack<>();
        int[] currentSet;
        ArrayList<Integer> returnSet = new ArrayList<>();
        int[] returnArray = new int[data.length];

        // separate bytes
        for (int i = 0; i < data.length; i += 8) {
            byteSets.push(Arrays.copyOfRange(data, i, i + 8));
        }
        // reverse order
        while (!byteSets.empty()) {
            currentSet = byteSets.pop();
            for (int bit : currentSet) {
                returnSet.add(bit);
            }
        }
        // convert to primitive
        for (int i = 0; i < returnArray.length; i++) {
            returnArray[i] = returnSet.get(i);
        }

        return returnArray;
    }

    public static void main(String[] args) {
        for (int bit : DataReverse(new int[] {1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0})) {
            System.out.print(bit);
        }
    }
}
