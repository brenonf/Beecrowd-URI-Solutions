n = int(input())
r =list()
r = input().split()
rrr = 0
for i in range(len(r)-1):
    if int(r[i]) > int(r [i +1]):
        rrr= i + 2
        break
print(rrr)
