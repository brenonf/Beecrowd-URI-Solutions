while True:
    n = list(map(int, input().split()))
    if n[0] == 0 and n[1] == 0:
        break
    
    alice = set(map(int, input().split()))
    bia = set(map(int, input().split()))

    difA = alice.difference(bia)
    difB = bia.difference(alice)

    if len(difA) <= len(difB):
        print(len(difA))
    else:
        print(len(difB))
