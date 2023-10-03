Here is a Python console application that groups an array of strings into anagrams:

```python
from collections import defaultdict

def group_anagrams(strs):
    anagrams = defaultdict(list)
    for word in strs:
        anagrams["".join(sorted(word))].append(word)
    return list(anagrams.values())

def main():
    strs = input("Enter words separated by comma: ").split(',')
    print(group_anagrams(strs))

if __name__ == "__main__":
    main()
```

You can run this application in the console. It will ask you to enter words separated by commas. After you enter the words, it will print the groups of anagrams.