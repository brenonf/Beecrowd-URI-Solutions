while True:
    try:
        n = input().strip()
        if n=="":
            break
        
        if int(n)%6==0:
            print("Y")
        else:
            print("N")
    except EOFError:
        break
