def group_anagrams(strs):
    anagrams = defaultdict(list)
    for word in strs:
        anagrams["".join(sorted(word))].append(word)
    return list(anagrams.values())