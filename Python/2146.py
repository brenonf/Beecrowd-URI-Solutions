while True:
    try:
        n = int(input())
        print(n-1)
    except EOFError:
        break