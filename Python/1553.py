dic = {}
cont = 0

while True:
    n = list(map(int, input().split()))
    if n[0] == 0 and n[1] == 0:
        break
    listao = list(map(int, input().split()))

    for i in listao:
        if i in dic:
            dic[i] += 1
        else:
            dic[i] = 1

    for x in dic.values():
        if x >= n[1]:
            cont += 1

    print(cont)
    cont = 0
    dic.clear()
