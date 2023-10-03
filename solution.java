Here is a Java console application that groups an array of strings into anagrams:

```java
import java.util.*;

public class Main {
    public static void main(String[] args) {
        String[] arr = {"cat", "dog", "tac", "god", "good", "act"};
        System.out.println(groupAnagrams(arr));
    }

    public static List<List<String>> groupAnagrams(String[] strs) {
        if (strs.length == 0) return new ArrayList<>();
        Map<String, List<String>> map = new HashMap<>();
        for (String s : strs) {
            char[] ca = s.toCharArray();
            Arrays.sort(ca);
            String key = String.valueOf(ca);
            if (!map.containsKey(key)) map.put(key, new ArrayList<>());
            map.get(key).add(s);
        }
        return new ArrayList<>(map.values());
    }
}
```

This program works by sorting the characters in each string and using the sorted string as a key in a map. All strings that are anagrams of each other will result in the same key when sorted. The map's values are lists of strings, so anagrams are grouped together. The program then returns a list of these groups.