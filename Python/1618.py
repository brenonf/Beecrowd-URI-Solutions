n = int(input())


for _ in range(n):
    listao = list(map(int, input().split()))
    
    x = listao[8]
    
    y = listao[9]

    if (
        listao[0] <= x and
        listao[1] <= y and
        listao[2] >= x and
        listao[3] <= y and
        listao[4] >= x and
        listao[5] >= y and
        listao[6] <= x and
        listao[7] >= y
    ):
        print(1)
    else:
        print(0)
