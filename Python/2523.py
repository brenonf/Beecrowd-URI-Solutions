while True:
    try:
        a = input()
        n = int(input())
        m = input().split()
        msg =''
        for i in range(n):
            msg += a[int(m[i])-1]

        print(msg)
    except EOFError:
        break
