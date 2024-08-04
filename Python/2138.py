while True:
    try:
        n = input()
        if not n:
            break

        freq = {}
        for char in n:
            if char in freq:
                freq[char] += 1
            else:
                freq[char] = 1

        maior = [char for char, cont in freq.items() if cont == max(freq.values())]
        maior.sort(reverse=True)

        print(maior[0])

    except EOFError:
        break
