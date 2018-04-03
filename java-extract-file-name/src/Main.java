import java.util.regex.*;

public class Main {

    public static String extractFileName(String dirtyFileName) {
        Pattern fileNamePattern = Pattern.compile("_.*?[.]\\w*");
        Matcher fileNameMatcher = fileNamePattern.matcher(dirtyFileName);

        fileNameMatcher.find();

        return fileNameMatcher.group().replaceFirst("_", "");
    }

    public static void main(String[] args) {
        System.out.println(extractFileName("1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION"));
        System.out.println(extractFileName("3362_iiskmp5pfnlqajpmoi9u1evpe1.jvj.3362a"));
        System.out.println(extractFileName("7560_94a9i7jbf9p863s6ql7qhone24.v1c.7560a"));
        System.out.println(extractFileName("1_FILE_NAM-E.EXTENSION.OTHEREXTENSIONadasdassdassds34"));
    }
}
