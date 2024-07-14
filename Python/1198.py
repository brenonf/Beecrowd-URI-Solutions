while True:
    try:
        a,b=list(map(int,input().split()))
    except ValueError:
            break
    except EOFError:
            break
    print(abs(a-b))
